namespace LifeLog.Services.Api.Jwt;

public interface ITokenService
{
    (string token, int expiresInSeconds) CreateAccessToken(string userId, string email, string role);
    string CreateRefreshToken();
}