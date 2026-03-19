using System;

namespace LifeLog.Services.Api.Jwt;

public interface IRefreshTokenStore
{
    void Save(string refreshTokenPlain, string userId, DateTime expiresAtUtc);
    RefreshTokenEntry? Find(string refreshTokenPlain);
    void Revoke(string refreshTokenPlain);
}