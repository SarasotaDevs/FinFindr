public class UserService
{

    private readonly DatabaseRepository _repository;

    public UserService(DatabaseRepository repository)
    {
        _repository = repository;
    }


    public string addUser(User user)
    {

            string insertQuery = $"INSERT INTO users (name, email) VALUES ('{user.name}', '{user.email}')";
            _repository.executeQuery(insertQuery);
            string response = $"Name: {user.name} added\nEmail: {user.email} added";
            return response;
    }

    public List<string> getAllUsers()
    {
    string selectQuery = "SELECT name, email FROM users";
    List<string> users = _repository.executeQuery(selectQuery);
    return users;
    }

    public string deleteUser(User user)
    {
        string selectQuery = $"SELECT COUNT(*) FROM users WHERE email = '{user.email}'";
        int count = _repository.executeQuery(selectQuery).Count;
        if (count == 0)
        {
            string notFoundResponse = $"User with email {user.email} does not exist in the database.";
            return notFoundResponse;
        }

        string deleteQuery = $"DELETE FROM users WHERE email = '{user.email}'";
        _repository.executeQuery(deleteQuery);
        string response =  $"User with email {user.email} has been deleted from the database.";
        return response;
    }

}


