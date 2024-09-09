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


}
