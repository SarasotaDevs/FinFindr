using Microsoft.AspNetCore.Builder;

public static class ApplicationRoutes {

    public static void ConfigureRoutes(WebApplication app) {
        AIRoutes.ConfigureAIRoutes(app);
        UserRoutes.ConfigureUserRoutes(app);
    }
} 