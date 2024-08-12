
    public class AIService : IAIConnection
    {
        private readonly IAIConnection _aiConnection;

        public AIService(IAIConnection aiConnection)
        {
            _aiConnection = aiConnection;
        }

        public string ConnectAI()
        {
            return _aiConnection.ConnectAI();
        }
    }
