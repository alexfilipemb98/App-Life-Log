namespace LifeLog.Services.Api.JWT;

public interface IRefreshTokenStore
{
    void Save(string refreshTokenPlain, string userId, DateTime expiresAtUtc);
    RefreshTokenEntry? Find(string refreshTokenPlain);
    void Revoke(string refreshTokenPlain);
}