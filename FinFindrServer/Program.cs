
using Microsoft.Extensions.DependencyInjection;
using Auth0.AspNetCore.Authentication;

using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();



Env.Load();

builder.Services.AddAuth0WebAppAuthentication(options =>


{
    string domainValue = Environment.GetEnvironmentVariable("OAUTH_DOMAIN");
    string clientIdValue = Environment.GetEnvironmentVariable("OAUTH_CLIENT_ID");

    string domain = "Auth0:" + domainValue;
    string clientId = "Auth0:" + clientIdValue;

    options.Domain = builder.Configuration[domain];
    options.ClientId = builder.Configuration[clientId];
});

Startup.Configure(builder);