public class UserService
{

    public string addUser(string name, string email)
    {
        using (var connection = new NpgsqlConnection(_connString))
        {
            connection.Open();

            EnsureUsersTableExists(connection);

            using (var command = new NpgsqlCommand("INSERT INTO users (name, email) VALUES (@name, @Email)", connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@Email", email);

                command.ExecuteNonQuery();
                Console.WriteLine("User added successfully.");

                return $"Name: {name} added\nEmail: {email} added";
            }
        }
    }
    public List<string> getAllUsers()
    {
        List<string> userList = new List<string>();

        using (var connection = new NpgsqlConnection(_connString))
        {
            connection.Open();

            // Ensure the table exists
            EnsureUsersTableExists(connection);

            // Query to get all users
            string query = "SELECT id, name, email FROM users";

            using (var command = new NpgsqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    // Loop through the result set
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string email = reader.GetString(2);

                        userList.Add($"{id} | {name} | {email}");
                    }
                }
            }
        }

        return userList;
    }

    public void deleteUser(string email)
    {
        using (var connection = new NpgsqlConnection(_connString))
        {
            connection.Open();

            // Ensure the table exists
            EnsureUsersTableExists(connection);

            // Delete user by email
            string deleteQuery = "DELETE FROM users WHERE email = @Email";

            using (var command = new NpgsqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Email", email);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("User deleted successfully.");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }
        }
    }
}