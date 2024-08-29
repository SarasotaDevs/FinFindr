using Microsoft.Data.Sqlite;

public class DatabaseRepository 
{

    private readonly string _connString;


    public DatabaseRepository(string connString) {
        _connString = connString;
    }


    public void addUser(string name, string email)
    {
        using (var connection = new SqliteConnection(_connString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO users (name, email) VALUES (@Name, @Email)";
            using (var command = new SqliteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.ExecuteNonQuery();
            }
        }
    }


    public void getData()
    {
        using (var connection = new SqliteConnection(_connString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM users";
            using (var command = new SqliteCommand(selectQuery, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string email = reader.GetString(2);

                        Console.WriteLine($"ID: {id}, Name: {name}, Email: {email}");
                    }
                }
            }

            string selectByIdQuery = "SELECT * FROM users WHERE id = 1";
            using (var command = new SqliteCommand(selectByIdQuery, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string email = reader.GetString(2);

                        Console.WriteLine($"Element with ID 1: ID: {id}, Name: {name}, Email: {email}");
                    }
                }
            }
        }
    }

}