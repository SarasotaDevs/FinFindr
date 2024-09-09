using Npgsql;


public class DatabaseRepository 
{

    private readonly string _connString;


    public DatabaseRepository(string connString) {
        _connString = connString;

    }


    public void addUser(string name, string email) {
    using (var connection = new NpgsqlConnection(_connString))
    {
        // Open the connection
        connection.Open();

        // Ensure the connection is opened before executing the command
        if (connection.State == System.Data.ConnectionState.Open)
        {
            using (var command = new NpgsqlCommand("SELECT column FROM table", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0)); // Process the result
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Connection failed to open.");
        }
    }
    }


    public void getData() {
    using (var connection = new NpgsqlConnection(_connString))
    {
        // Open the connection
        connection.Open();

        // Ensure the connection is opened before executing the command
        if (connection.State == System.Data.ConnectionState.Open)
        {
            using (var command = new NpgsqlCommand("SELECT column FROM table", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0)); // Process the result
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Connection failed to open.");
        }
    }



}
}