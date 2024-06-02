using api.Requests;

namespace api.Http;

public sealed class KeycloakHttpClient(HttpClient client)
{
    const string KeycloakUri = "http://keycloak:8080";
    
    public async Task GetAdminToken()
    {
        var endpoint = $"{KeycloakUri}/realms/master/protocol/openid-connect/token";
        var request = new GetTokenRequest(clientId: "admin-cli", username: "admin", password: "admin");
        var content = request.ToFormUrlEncodedContent();
        Console.WriteLine(await content.ReadAsStringAsync());
        var response = await client.PostAsync(endpoint, content);
        var responseStr = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseStr);
    }
}
