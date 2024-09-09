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

                client.MapPost("/signup", (UserService userService, User user) =>
                {
                    // string res = userService.addUser(user.name, user.email);
                    string res = "";
                    Console.WriteLine(user.name);
                    return res;
                })
                .WithName("Sign Up")
                .WithOpenApi();

                client.MapGet("/allusers", (UserService userService) =>
                {
                    List<string> res = userService.getAllUsers();
                    return res;
                })
                .WithName("Gets All Users")
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


    public class User
{
    public required string name { get; set; }
    public required string email { get; set; }

}