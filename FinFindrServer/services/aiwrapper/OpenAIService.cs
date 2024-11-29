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
    Only provide the name of the best card to use for the given vendor type. If no suitable card exists, return 'card not found'.
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