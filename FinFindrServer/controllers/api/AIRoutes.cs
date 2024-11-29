using Microsoft.AspNetCore.Builder;

public static class AIRoutes {
    
    public static void ConfigureAIRoutes(WebApplication app) {
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

        client.MapGet("/getfinance/{userId}", (OpenAIService openAIService, string userId) =>
        {
            
            string vendorType = "restaurant";
            var cards = new List<string> { 
                "Chase Sapphire Preferred",
                "American Express Gold Card", 
                "Capital One Venture",
                "Citi Double Cash Card"
            };

            string cardList = string.Join(", ", cards.Take(cards.Count - 1)) + " and " + cards.Last();
            string request = $"I have {cardList}. Which credit card should I use when I am at a {vendorType}?";
            return openAIService.LogTest(request);
        })
        .WithName("GetFinance")
        .WithOpenApi();

        client.MapGet("/cards/{userId}", (OpenAIService openAIService) =>
        {
            var cards = new List<string> { 
                "Chase Sapphire Preferred",
                "American Express Gold Card", 
                "Capital One Venture",
                "Citi Double Cash Card"
            };
            return cards;
        })
        .WithName("GetCards")
        .WithOpenApi();
    }

    public class RequestModel
    {
        public required string Query { get; set; }
    }
} 