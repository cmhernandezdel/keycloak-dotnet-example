using api.Attributes;

namespace api.Requests;

public sealed record GetTokenRequest
{
    [FormUrlEncodedContentKey("client_id")]
    public string ClientId { get; }

    [FormUrlEncodedContentKey("username")]
    public string Username { get; }

    [FormUrlEncodedContentKey("password")]
    public string Password { get; }

    [FormUrlEncodedContentKey("grant_type")]
    public string GrantType { get; }

    public GetTokenRequest(string clientId, string username, string password)
    {
        ClientId = clientId;
        Username = username;
        Password = password;
        GrantType = "password";
    }
}
