using api.Http;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient<KeycloakHttpClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/token", async (KeycloakHttpClient client) => {
    var token = await client.GetAdminToken();
    Console.WriteLine($"Bearer {token}");
})
.WithName("GetAdminToken")
.WithOpenApi();

app.Run();