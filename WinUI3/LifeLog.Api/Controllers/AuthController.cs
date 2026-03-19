using LifeLog.Core.Entities;
using LifeLog.Core.Interfaces;
using LifeLog.Core.Models;
using LifeLog.Services.Api.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using static LifeLog.Services.Api.Jwt.TokenService;

namespace LifeLog.Services.Api.Controllers;

/// <summary>
/// Api controller para as autenticações
/// </summary>
[ApiExplorerSettings(GroupName = "v1")]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    #region MAIN

    //PRIVATE
    private readonly ITokenService _tokens;
    private readonly IRefreshTokenStore _refreshStore;
    private readonly IUserRepo _userDB;

    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="tokens"></param>
    /// <param name="refreshStore"></param>
    public AuthController(ITokenService tokens, IRefreshTokenStore refreshStore, IUserRepo userDB)
    {
        _tokens = tokens;
        _refreshStore = refreshStore;
        _userDB = userDB;
    }

    #endregion

    #region AUTH

    /// <summary>
    /// Efetuar o login
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] LoginModel model)
    {
        if (model is null || !ModelState.IsValid)
            return ValidationProblem(ModelState);

        (bool logged, LoggedUserModel? user, string message) = await _userDB.Login(model.Email!, model.Password!);

        if (user is null)
            return Unauthorized("Email ou password inválidos.");

        (string? access, int expiresIn) = _tokens.CreateAccessToken(user.Id.ToString(), model!.Email!, "User");

        string refresh = _tokens.CreateRefreshToken();
        DateTime refreshExp = DateTime.UtcNow.AddDays(Engine.JwtRefreshTokenDays);

        _refreshStore.Save(refresh, user.Id.ToString(), refreshExp);

        return Ok(new TokenResponse(access, refresh, expiresIn));
    }

    /// <summary>
    /// Rrefresh do token
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Refresh([FromBody] RefreshRequest req)
    {
        RefreshTokenEntry? entry = _refreshStore.Find(req.RefreshToken);

        if (entry is null || entry.Revoked || entry.ExpiresAtUtc <= DateTime.UtcNow)
            return Unauthorized("Refresh token inválido");

        if (string.IsNullOrWhiteSpace(entry.UserId) || Guid.TryParse(entry.UserId, out Guid uId) || uId == Guid.Empty)
            return Unauthorized("Not Authorized!");

        _refreshStore.Revoke(req.RefreshToken);

        (User? user, string message) = await _userDB.GetByKey(uId);

        if (user is null)
            return Unauthorized("Not Authorized!");

        string role = "Admin";

        (string? access, int expiresIn) = _tokens.CreateAccessToken(user.Id.ToString()!, user.Email!, role);

        if (string.IsNullOrWhiteSpace(access))
            return Unauthorized("Not Authorized!");

        string newRefresh = _tokens.CreateRefreshToken();

        _refreshStore.Save(newRefresh, user.Id.ToString()!, DateTime.UtcNow.AddDays(Engine.JwtRefreshTokenDays));

        return Ok(new TokenResponse(access, newRefresh, expiresIn));
    }

    #endregion

    #region GET'S

    /// <summary>
    /// Mostrar quem está autenticado
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Me()
    {
        if (User.Identity is null)
            return Unauthorized("Not Authorized!");


        if (!User.Identity.IsAuthenticated)
            return Unauthorized("Not Authenticated!");

        return Ok(new
        {
            User = User.Identity.Name,
            Claims = User.Claims.Select(c => new { c.Type, c.Value })
        });
    }

    #endregion
}