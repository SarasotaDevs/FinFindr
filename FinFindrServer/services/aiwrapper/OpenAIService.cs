using OpenAI.Chat;


public class OpenAIService
{
    public OpenAIService(string key)
    {
        client = new(model: "gpt-4o", key);
    }
    
    private ChatClient client { get; set; }

    public ChatClient Client {
        get { return client; }
    }
        public string LogTest(string query) {
            // make a try catch

            string systemChatMessage = @"
            Don't have an introduction of the program and just supply the bullets. Only search for the card. If the card does not exisit return 'card not found'. You are a knowledgeable assistant that provides detailed, organized information about credit programs. When responding, follow this format:
                Cash Back Rewards:

                List key rewards, focusing on points earned in specific spending categories.
                Bonus Offers:

                Highlight any welcome bonuses and recurring monthly credits.
                Annual Dining Credit:

                Detail the amount and applicable services for dining credits.
                Travel Benefits:

                Mention any travel-related credits and foreign transaction fee waivers.
                Offers:
                Explain access to additional discounts or points through partner offers.
                Each category should have bullet points highlighting the most relevant information, similar to the example provided.
            ";
            
            try
            {
                
                 ChatCompletion completion = client.CompleteChat( [
                    new SystemChatMessage(systemChatMessage),
                    new UserChatMessage(query),
                    ]);
    
                return completion.Content[0].Text;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        
       
    }

}