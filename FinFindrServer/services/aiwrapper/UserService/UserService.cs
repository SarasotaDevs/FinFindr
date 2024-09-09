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
            return $"Name: {user.name} added\nEmail: {user.email} added";
    }

    public List<string> getAllUsers()
    {
    string selectQuery = "SELECT name, email FROM users";
    List<string> users = _repository.executeQuery(selectQuery);
    return users;
    }

}


