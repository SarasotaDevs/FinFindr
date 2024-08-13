using OpenAI.Chat;
using DotNetEnv;

public class AIConnection
{

    private ChatClient client { get; set; }

    public ChatClient Client => client;


    
    public ChatClient connectClient() {

        string key = Environment.GetEnvironmentVariable("MY_API_KEY");

        client = new(model: "gpt-4o", key);

        return client;
    }


}