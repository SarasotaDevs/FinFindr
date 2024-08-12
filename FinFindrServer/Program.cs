using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AppConfig.AIConnectionServiceInjection(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/connectai", (AIService aiService) =>
{
    return aiService.ConnectAI();
})
.WithName("Connect AI")
.WithOpenApi();

app.Run();
