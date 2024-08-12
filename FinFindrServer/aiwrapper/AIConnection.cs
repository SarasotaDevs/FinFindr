

public interface IAIConnection
{
    string ConnectAI();
}
public class AIConnection : IAIConnection
{
    public string ConnectAI()
    {
        return "AI Connected";
    }
}