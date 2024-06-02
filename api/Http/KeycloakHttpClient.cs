using System.Text.Json;
using api.Requests;
using api.Responses;

namespace api.Http;

public sealed class KeycloakHttpClient(HttpClient client)
{
    const string KeycloakUri = "http://keycloak:8080";
    
    public async Task<string> GetAdminToken()
    {
        var endpoint = $"{KeycloakUri}/realms/master/protocol/openid-connect/token";
        var request = new GetTokenRequest(clientId: "admin-cli", username: "admin", password: "admin");
        var content = request.ToFormUrlEncodedContent();
        var response = await client.PostAsync(endpoint, content);
        var responseStr = await response.Content.ReadAsStringAsync();
        var deserializedResponse = JsonSerializer.Deserialize<GetTokenResponse>(responseStr)!;
        return deserializedResponse.AccessToken;
    }
}
