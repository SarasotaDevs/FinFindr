public static class AppConfig {
    public static void AIConnectionServiceInjection(IServiceCollection services) {
        services.AddTransient<IAIConnection, AIConnection>();
        services.AddTransient<AIService>();
    }
}