public static class AppConfig {
    public static void AIConnectionServiceInjection(IServiceCollection services) {
        services.AddSingleton<AIConnection>();
        services.AddTransient<AIService>();
    }
}