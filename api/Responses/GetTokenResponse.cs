using System.Text.Json.Serialization;

namespace api.Responses;

public sealed record GetTokenResponse
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; }

    [JsonPropertyName("expires_in")]
    public uint ExpiresInSeconds { get; }

    [JsonPropertyName("refresh_expires_in")]
    public uint RefreshExpiresInSeconds { get; }

    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; }

    [JsonPropertyName("token_type")]
    public string TokenType { get; }

    [JsonPropertyName("not-before-policy")]
    public int NotBeforePolicy { get; }

    [JsonPropertyName("session_state")]
    public Guid SessionState { get; }

    [JsonPropertyName("scope")]
    public string Scope { get; }

    public GetTokenResponse(string accessToken, uint expiresInSeconds, uint refreshExpiresInSeconds, string refreshToken, string tokenType, int notBeforePolicy, Guid sessionState, string scope)
    {
        AccessToken = accessToken;
        ExpiresInSeconds = expiresInSeconds;
        RefreshExpiresInSeconds = refreshExpiresInSeconds;
        RefreshToken = refreshToken;
        TokenType = tokenType;
        NotBeforePolicy = notBeforePolicy;
        SessionState = sessionState;
        Scope = scope;
    }
}
