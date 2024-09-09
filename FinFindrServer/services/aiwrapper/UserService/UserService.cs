public class UserService
{

    private readonly DatabaseRepository _repository;

    public UserService(DatabaseRepository repository)
    {
        _repository = repository;
    }


    public string addUser(string name, string email)
    {

            string insertQuery = $"INSERT INTO users (name, email) VALUES ('{name}', '{email}')";
            _repository.executeQuery(insertQuery);
            return $"Name: {name} added\nEmail: {email} added";
    }

    public List<string> getAllUsers()
    {
    string selectQuery = "SELECT name, email FROM users";
    List<string> users = _repository.executeQuery(selectQuery);
    return users;
    }

}


