using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string serverName = "YourServerName";
        string username = "YourUsername";
        string password = "YourPassword";

        string createDatabaseScript = @"
            IF NOT EXISTS (
                SELECT name
                FROM sys.databases
                WHERE name = 'KiddEsports'
            )
            BEGIN
                CREATE DATABASE KiddEsports;
            END";

        string createTablesScript = @"
            USE KiddEsports;

            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TeamInfo')
            BEGIN
                CREATE TABLE TeamInfo (
                    ID INT PRIMARY KEY IDENTITY(1,1),
                    TeamName VARCHAR(50),
                    PrimaryContact VARCHAR(50),
                    ContactEmail VARCHAR(50),
                    Points INT
                );
            END

            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TeamResults')
            BEGIN
                CREATE TABLE TeamResults (
                    ID INT PRIMARY KEY IDENTITY(1,1),
                    EventName VARCHAR(50),
                    GamePlayed VARCHAR(50),
                    Team VARCHAR(50),
                    OpposingTeam VARCHAR(50),
                    Result VARCHAR(50)
                );
            END

            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Event')
            BEGIN
                CREATE TABLE Event (
                    ID INT PRIMARY KEY IDENTITY(1,1),
                    EventName VARCHAR(50),
                    EventLocation VARCHAR(50),
                    EventDate VARCHAR(50)
                );
            END

            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'GamePlayed')
            BEGIN
                CREATE TABLE GamePlayed (
                    ID INT PRIMARY KEY IDENTITY(1,1),
                    GameName VARCHAR(50),
                    GameType VARCHAR(50)
                );
            END";

        // Connection string without specifying an initial database
        string connectionString = $"Server={serverName};User Id={username};Password={password};";

        try
        {
            // Connect to the SQL Server instance
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create the database
                using (SqlCommand command = new SqlCommand(createDatabaseScript, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Database created successfully.");
                }

                // Create tables in the database
                using (SqlCommand command = new SqlCommand(createTablesScript, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Tables created successfully.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
