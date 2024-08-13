using Microsoft.Extensions.DependencyInjection;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Startup.AppConfig(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
Env.Load();


app.MapGet("/connectai", (OpenAIService openAIService) =>
{
    return openAIService.Client;
})
.WithName("Connect AI")
.WithOpenApi();


app.MapGet("/getai", (OpenAIService openAIService) =>
{
    return openAIService.LogTest();
})
.WithName("GetAI")
.WithOpenApi();


app.Run();
