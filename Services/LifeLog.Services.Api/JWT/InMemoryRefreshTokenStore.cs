using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;

namespace LifeLog.Services.Api.JWT;

public class InMemoryRefreshTokenStore : IRefreshTokenStore
{
    private readonly ConcurrentDictionary<string, RefreshTokenEntry> _db = new();

    public void Save(string refreshTokenPlain, string userId, DateTime expiresAtUtc)
    {
        string hash = Hash(refreshTokenPlain);
        _db[hash] = new RefreshTokenEntry { UserId = userId, TokenHash = hash, ExpiresAtUtc = expiresAtUtc };
    }

    public RefreshTokenEntry? Find(string refreshTokenPlain)
    {
        string hash = Hash(refreshTokenPlain);
        return _db.TryGetValue(hash, out var entry) ? entry : null;
    }

    public void Revoke(string refreshTokenPlain)
    {
        string hash = Hash(refreshTokenPlain);
        if (_db.TryGetValue(hash, out var entry))
            entry.Revoked = true;
    }

    private static string Hash(string token)
    {
        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(token));
        return Convert.ToBase64String(bytes);
    }
}