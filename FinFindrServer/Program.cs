
using Microsoft.Extensions.DependencyInjection;
using Auth0.AspNetCore.Authentication;

using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();



Env.Load();

Startup.Configure(builder);