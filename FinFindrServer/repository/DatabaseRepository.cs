using Npgsql;
using System;

public class DatabaseRepository
{
    private readonly string _connString;

    public DatabaseRepository(string connString)
    {
        _connString = connString;
    }

        private void EnsureUsersTableExists(NpgsqlConnection connection)
    {
        string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS users (
                id SERIAL PRIMARY KEY,
                name VARCHAR(100),
                email VARCHAR(100) UNIQUE
            )";

        using (var command = new NpgsqlCommand(createTableQuery, connection))
        {
            command.ExecuteNonQuery();
            Console.WriteLine("Checked that 'users' table exists or created it.");
        }
    }

  public List<string> executeQuery(string query)
{
    List<string> results = new List<string>();

    try
    {
        using (var connection = new NpgsqlConnection(_connString))
        {
            connection.Open();

            EnsureUsersTableExists(connection);

            using (var command = new NpgsqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    // Loop through the result set and add each row to the results list
                    while (reader.Read())
                    {
                        var row = new List<string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader[i].ToString());
                        }

                        // Combine the row data into a single string (or customize as needed)
                        results.Add(string.Join(" | ", row));
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Failed to execute query: {ex.Message}");
        return new List<string> { "Failure" };
    }

    return results;
}

}
