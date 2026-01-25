namespace LifeLog.Services.Api.JWT;

public class RefreshTokenEntry
{
    public required string UserId { get; init; }
    public required string TokenHash { get; init; }
    public DateTime ExpiresAtUtc { get; init; }
    public bool Revoked { get; set; }
}