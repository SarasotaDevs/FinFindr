
using Microsoft.Extensions.DependencyInjection;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


Startup.AppConfig(builder.Services);


var app = builder.Build();

Env.Load();


app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var client = app.MapGroup("/api/client");

client.MapGet("/connectai", (OpenAIService openAIService) =>
{
    return openAIService.Client;
})
.WithName("Connect AI")
.WithOpenApi();


client.MapGet("/getai", (OpenAIService openAIService) =>
{
    return openAIService.LogTest();
})
.WithName("GetAI")
.WithOpenApi();

app.Run();

