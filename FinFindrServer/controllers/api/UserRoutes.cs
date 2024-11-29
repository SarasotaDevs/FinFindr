using Microsoft.AspNetCore.Builder;

public static class UserRoutes {

    public static void ConfigureUserRoutes(WebApplication app) {
        var client = app.MapGroup("/api/auth");

        client.MapPost("/signup", (UserService userService, User user) =>
        {
            string res = userService.addUser(user);
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

        client.MapPost("/deleteuser", (UserService userService, User user) =>
        {
            string res = userService.deleteUser(user);
            return res;
        })
        .WithName("Deletes User")
        .WithOpenApi();
    }
} 