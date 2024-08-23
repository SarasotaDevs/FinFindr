using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Auth0.AspNetCore.Authentication;

public class AccountController
{
    public async Task Login(string returnUrl = "/")
    {
        var authenticationProperties = new LoginAuthenticationPropertiesBuilder()
            // Indicate here where Auth0 should redirect the user after a login.
            // Note that the resulting absolute Uri must be added to the
            // **Allowed Callback URLs** settings for the app.
            .WithRedirectUri(returnUrl)
            .Build();

        await HttpContext.ChallengeAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
    }
}