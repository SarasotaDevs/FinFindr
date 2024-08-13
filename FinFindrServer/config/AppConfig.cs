public static class Startup {

    public static void AppConfig(IServiceCollection services) {

        
        services.AddSingleton<OpenAIService>(sp => {
            string key = Environment.GetEnvironmentVariable("MY_API_KEY"); 
            return new OpenAIService(key);
        }
            );
    }
}