using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace LifeLog.Services.Api.Jwt;

public class TokenService : ITokenService
{
    private readonly IConfiguration _cfg;

    public TokenService(IConfiguration cfg) => _cfg = cfg;

    public record TokenResponse(string AccessToken, string RefreshToken, int ExpiresInSeconds);

    public (string token, int expiresInSeconds) CreateAccessToken(string userId, string email, string role)
    {
        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, userId),
            new(ClaimTypes.NameIdentifier, userId),
            new(ClaimTypes.Name, email),
            new(ClaimTypes.Role, role),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Engine.JwtKey));
        var creds = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

        var expires = DateTime.UtcNow.AddMinutes(Engine.JwtAccessTokenMinutes);

        var token = new JwtSecurityToken(
            issuer: Engine.JwtIssuer,
            audience: Engine.JwtAudience,
            claims: claims,
            expires: expires,
            signingCredentials: creds);

        var jwtString = new JwtSecurityTokenHandler().WriteToken(token);
        return (jwtString, Engine.JwtAccessTokenMinutes * 60);
    }

    public string CreateRefreshToken()
    {
        var bytes = RandomNumberGenerator.GetBytes(64);
        return Convert.ToBase64String(bytes);
    }
}