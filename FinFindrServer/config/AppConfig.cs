public static class Startup {
    public static void Configure(WebApplicationBuilder builder) {
        // Add CORS services
        ServiceConfig(builder.Services);

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // Use CORS middleware
        app.UseCors("AllowLocalhost8081");

        ApplicationRoutes.ConfigureRoutes(app);

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.UseAuthentication();

        app.Run();
    }

    public static void ServiceConfig(IServiceCollection services) {
        services.AddSingleton<OpenAIService>(sp => {
            string key = Environment.GetEnvironmentVariable("MY_API_KEY") ?? string.Empty; 
            return new OpenAIService(key);
        });

        services.AddSingleton<DatabaseRepository>(sp => {
            string key = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? string.Empty; 
            return new DatabaseRepository(key);
        });

        services.AddSingleton<UserService>();

        // Add CORS policy
        services.AddCors(options =>
        {
            options.AddPolicy("AllowLocalhost8081",
                builder =>
                {
                    builder.WithOrigins("http://localhost:8081")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
        });
    }
}