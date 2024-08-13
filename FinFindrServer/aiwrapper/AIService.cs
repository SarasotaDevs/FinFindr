using OpenAI.Chat;

    public class AIService
    {
        private readonly AIConnection _aiConnection;

        public AIService(AIConnection aiConnection)
        {
            _aiConnection = aiConnection;
        }

        public string ConnectAI()
        {
            ChatClient client = _aiConnection.connectClient();

            return "AI Connected";


        }

        public ChatClient getAI()
        {
            ChatClient client = _aiConnection.client;

            return client;

        }
    }
