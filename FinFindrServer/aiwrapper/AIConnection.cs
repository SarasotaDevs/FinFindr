using OpenAI.Chat;



public interface IAIConnection

{
    string ConnectAI();
}
public class AIConnection : IAIConnection
{
    public string ConnectAI()
    
    {

        string key = "<add key>";
        ChatClient client = new(model: "gpt-4o", key);

        ChatCompletion completion = client.CompleteChat("what are the membership reward benefits of the american express gold card, no verbose, just the numbers and location");

        Console.WriteLine(completion);

        return "AI Connected";
    }
}