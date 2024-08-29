
public static class Startup {
     public static void Configure(WebApplicationBuilder builder) {

        // Configure singletons, and application app instances on runtime



        ServiceConfig(builder.Services);

     

        var app = builder.Build();



        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }


        // configures the api routes through the application
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
        }
            );

      services.AddSingleton<DatabaseRepository>(sp => {
            string key = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? string.Empty; 
            return new DatabaseRepository(key);
        }
            );
        

    }
}