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

    public string LogTest() {
        ChatCompletion completion = client.CompleteChat("Say 'this is a test.'");
    
        return completion.Content[0].Text;
    }

}