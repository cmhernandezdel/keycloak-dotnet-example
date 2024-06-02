namespace api.Requests;

public sealed record RegisterRequest
{
    public string Username { get; }

    public string Password { get; }

    public string EmailAddress { get; }

    public RegisterRequest(string username, string password, string emailAddress)
    {
        Username = username;
        Password = password;
        EmailAddress = emailAddress;
    }
}
