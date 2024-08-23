using Microsoft.AspNetCore.Builder;

public static class ApplicationRoutes {
    
        public static void ConfigureClientRoutes(WebApplication app) {
               var client = app.MapGroup("/api/client");

                client.MapGet("/connectai", (OpenAIService openAIService) =>
                {
                    return openAIService.Client;
                })
                .WithName("Connect AI")
                .WithOpenApi();

                client.MapGet("/getai", (OpenAIService openAIService) =>
                {
                    return openAIService.LogTest("Say 'this is a test.'");
                })
                .WithName("GetAI")
                .WithOpenApi();


                client.MapPost("/getquery", (OpenAIService openAIService, RequestModel request) =>
                {
                    return openAIService.LogTest(request.Query);
                })
                .WithName("GetAI2")
                .WithOpenApi();
        }

        public static void ConfigureRoutes(WebApplication app) {
            ConfigureClientRoutes(app);
        }


    public class RequestModel
{
    public required string Query { get; set; }
}
     

}  