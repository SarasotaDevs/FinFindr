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

              public static void ConfigureAuthenicationRoutes(WebApplication app) {
               var client = app.MapGroup("/api/auth");

                client.MapGet("/signup", (DatabaseRepository databaseRepository) =>
                {
                    databaseRepository.addUser("Max Martin", "maxmartin54321@gmail.com");
                    return "Success";
                })
                .WithName("Sign Up")
                .WithOpenApi();


                client.MapGet("/data", (DatabaseRepository databaseRepository) =>
                {
                    databaseRepository.getData();
                    return "Success";
                })
                .WithName("Data")
                .WithOpenApi();
        }


        public static void ConfigureRoutes(WebApplication app) {
            ConfigureClientRoutes(app);
            ConfigureAuthenicationRoutes(app);
        }


    public class RequestModel
{
    public required string Query { get; set; }
}
     

}  