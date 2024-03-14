
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;


namespace ClassLibrary
{
    public class TeamDTO
    {
        public string TeamName { get; set; }
        public string PrimaryContact { get; set; }
        public string ContactEmail { get; set; }
        public int Points { get; set; }
        public int ID { get; set; }
    }
    public class ResultDTO
    {
        public string EventName { get; set; }
        public string GamePlayed { get; set; }
        public string Team { get; set; }
        public string OpposingTeam { get; set; }
        public string Result { get; set; }
        public int ID { get; set; }
    }
    public class EventDTO
    {
        public string EventName { get; set; }
        public string EventLocation { get; set; }
        public string EventDate { get; set; }
        public int ID { get; set; }
    }

    public class GamesPlayedDTO
    {
        public int ID { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
    }

    public class DataMapper
    {
      

        public void InitializeDatabase()
        {
            try
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Check if database exists
                    string checkDatabaseQuery = "SELECT COUNT(*) FROM sys.databases WHERE name = 'KiddEsports'";
                    SqlCommand checkDatabaseCommand = new SqlCommand(checkDatabaseQuery, connection);
                    int databaseCount = (int)checkDatabaseCommand.ExecuteScalar();

                    bool databaseExists = (databaseCount > 0);


                    // Check if user exists
                    string checkUserQuery = "IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'ClassLibrary') BEGIN SELECT 0; END ELSE BEGIN SELECT 1; END;";
                    SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection);
                    int userExists = (int)checkUserCommand.ExecuteScalar();
                    string pass = "KiddEsportsAdmin143@";
                    if (userExists == 0)
                    {
                        // Create the login

                        string createUserQuery = $"CREATE LOGIN ClassLibrary WITH PASSWORD = '{pass}';";
                        SqlCommand createUserCommand = new SqlCommand(createUserQuery, connection);
                        createUserCommand.ExecuteNonQuery();

                        // Grant permissions to the "ClassLibrary" user
                        string grantPermissionsQuery = @"
                    USE KiddEsports;
                    IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'ClassLibrary')
                    BEGIN
                        CREATE USER ClassLibrary FOR LOGIN ClassLibrary;
                        ALTER ROLE db_datareader ADD MEMBER ClassLibrary;
                        ALTER ROLE db_datawriter ADD MEMBER ClassLibrary;
                    END";
                        SqlCommand grantPermissionsCommand = new SqlCommand(grantPermissionsQuery, connection);
                        grantPermissionsCommand.ExecuteNonQuery();
                    }




                    // Extract server name from the existing connection string
                  

                    // Update the connection string in properties
                    //NewconnectionString = $"Data Source=localhost;Initial Catalog=KiddEsports;User ID=ClassLibrary;Password={pass};";
                    //Properties.Settings.Default.ConnectionString = NewconnectionString;
                    //Properties.Settings.Default.Save();


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

                    // Execute the create database script
                    SqlCommand createDatabaseCommand = new SqlCommand(createDatabaseScript, connection);
                    createDatabaseCommand.ExecuteNonQuery();

                    // Execute the create tables script
                    SqlCommand createTablesCommand = new SqlCommand(createTablesScript, connection);
                    createTablesCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error: " + ex.Message);
            }
        }





        
        // Connection String
        private string connectionString;


        // Initialize counter with a starting value
        int counter = 0;

        public DataMapper(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Team Data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="teamName"></param>
        /// <param name="primaryContact"></param>
        /// <param name="contactEmail"></param>
        /// <param name="points"></param>

        public void AddTeamInfo(string teamName, string primaryContact, string contactEmail, string points)
        {
            // Construct the SQL query to insert team information into the database
            string query = "INSERT INTO TeamInfo (TeamName, PrimaryContact, ContactEmail, Points) VALUES ( @TeamName, @PrimaryContact, @ContactEmail, @Points)";

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the query to prevent SQL injection attacks

                command.Parameters.AddWithValue("@TeamName", teamName);
                command.Parameters.AddWithValue("@PrimaryContact", primaryContact);
                command.Parameters.AddWithValue("@ContactEmail", contactEmail);
                command.Parameters.AddWithValue("@Points", points);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Display success message
                    Console.WriteLine("Team information added successfully.");
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void DeleteTeamInfo(int id)
        {
            // Construct the SQL query to delete team information from the database
            string query = "DELETE FROM TeamInfo WHERE ID = @ID";

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameter to the query to specify the ID of the team to delete
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and get the number of rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                        Console.WriteLine("Team information deleted successfully.");
                    else
                        Console.WriteLine("No team information found with the given ID.");
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void SaveUpdatedTeamInfo(TeamDTO team)
        {
            // Construct the SQL query to update team information in the database
            string query = "UPDATE TeamInfo SET TeamName = @TeamName, PrimaryContact = @PrimaryContact, ContactEmail = @ContactEmail, Points = @Points WHERE ID = @ID";

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the query to specify the updated team information
                command.Parameters.AddWithValue("@TeamName", team.TeamName);
                command.Parameters.AddWithValue("@PrimaryContact", team.PrimaryContact);
                command.Parameters.AddWithValue("@ContactEmail", team.ContactEmail);
                command.Parameters.AddWithValue("@Points", team.Points);
                command.Parameters.AddWithValue("@ID", team.ID);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and get the number of rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                        Console.WriteLine("Team information updated successfully.");
                    else
                        Console.WriteLine("No team information found with the given ID.");
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public int GetTotalTeamRows()
        {
            int totalRows = 0;

            // Construct the SQL query to get the total number of rows in the TeamData table
            string query = "SELECT COUNT(*) FROM TeamData";

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and get the total number of rows
                    totalRows = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return totalRows;
        }

        public List<TeamDTO> MapTeamData(KiddEsportsDataSet yourTableNameDataSet)
        {
            List<TeamDTO> teamList = new List<TeamDTO>();

            // Iterate through the TeamInfo rows in the provided dataset and map them to TeamDTO objects
            foreach (KiddEsportsDataSet.TeamInfoRow row in yourTableNameDataSet.TeamInfo)
            {
                TeamDTO team = new TeamDTO
                {
                    TeamName = row.TeamName,
                    PrimaryContact = row.PrimaryContact,
                    ContactEmail = row.ContactEmail,
                    Points = Convert.ToInt32(row.Points),
                    ID = row.ID
                };

                teamList.Add(team);
            }

            return teamList;
        }

        public List<TeamDTO> SortTeamsByPoints()
        {
            List<TeamDTO> sortedTeams = new List<TeamDTO>();

            // Construct the SQL query to retrieve teams from the TeamInfo table and sort them by points in descending order
            string query = "SELECT * FROM TeamInfo ORDER BY Points DESC";

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result set
                    SqlDataReader reader = command.ExecuteReader();

                    // Iterate through the result set and map each row to a TeamDTO object
                    while (reader.Read())
                    {
                        TeamDTO team = new TeamDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            TeamName = reader["TeamName"].ToString(),
                            PrimaryContact = reader["PrimaryContact"].ToString(),
                            ContactEmail = reader["ContactEmail"].ToString(),
                            Points = Convert.ToInt32(reader["Points"])
                        };

                        sortedTeams.Add(team);
                    }

                    // Close the reader
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return sortedTeams;
        }
        public List<TeamDTO> SortTeamsAlphabetically()
        {
            List<TeamDTO> sortedTeams = new List<TeamDTO>();

            string query = "SELECT * FROM TeamInfo ORDER BY TeamName ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        TeamDTO team = new TeamDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            TeamName = reader["TeamName"].ToString(),
                            PrimaryContact = reader["PrimaryContact"].ToString(),
                            ContactEmail = reader["ContactEmail"].ToString(),
                            Points = Convert.ToInt32(reader["Points"]) // Parse Points as integer
                        };

                        sortedTeams.Add(team);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return sortedTeams;
        }
        public List<TeamDTO> SearchTeamsByName(string searchTerm)
        {
            List<TeamDTO> searchResults = new List<TeamDTO>();

            string query = "SELECT * FROM TeamInfo WHERE TeamName LIKE @SearchTerm";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        TeamDTO team = new TeamDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            TeamName = reader["TeamName"].ToString(),
                            PrimaryContact = reader["PrimaryContact"].ToString(),
                            ContactEmail = reader["ContactEmail"].ToString(),
                            Points = Convert.ToInt32(reader["Points"])
                        };

                        searchResults.Add(team);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return searchResults;
        }
        // Method to retrieve teams from the database (replace this with your database logic)
        public List<TeamDTO> GetTeamsFromDatabase()
        {
            // Replace this with your database logic to retrieve teams from the TeamInfo table
            List<TeamDTO> teams = new List<TeamDTO>();
            // Example:
            // teams = YourDataAccessLayer.GetTeamsFromDatabase();
            return teams;
        }

        // Method to export teams to CSV
        public void ExportTeamsToCSV(List<TeamDTO> teams, string fileName)
        {
            try
            {
                // Create a StringBuilder to hold CSV content
                StringBuilder csvContent = new StringBuilder();

                // Add headers to the CSV file
                csvContent.AppendLine("ID,TeamName,PrimaryContact,ContactEmail,Points");

                // Append each team to the CSV content
                foreach (TeamDTO team in teams)
                {
                    csvContent.AppendLine($"{team.ID},{team.TeamName},{team.PrimaryContact},{team.ContactEmail},{team.Points}");
                }

                // Define the path for the CSV file
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                // Write the CSV content to the file
                File.WriteAllText(filePath, csvContent.ToString());

                // Show success message to the user
               
            }
            catch (Exception ex)
            {
                
            }
        }

        //////////////
        //  Results //
        //////////////



        public void AddResultInfo(string eventName, string gamePlayed, string team, string opposingTeam, string result)
        {
            // Construct the SQL query to insert result information into the database
            string query = "INSERT INTO TeamResults (EventName, GamePlayed, Team, OpposingTeam, Result) VALUES (@EventName, @GamePlayed, @Team, @OpposingTeam, @Result)";

            // Get a new ID for the result


            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the query to prevent SQL injection attacks

                command.Parameters.AddWithValue("@EventName", eventName);
                command.Parameters.AddWithValue("@GamePlayed", gamePlayed);
                command.Parameters.AddWithValue("@Team", team);
                command.Parameters.AddWithValue("@OpposingTeam", opposingTeam);
                command.Parameters.AddWithValue("@Result", result);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Display success message
                    Console.WriteLine("Result information added successfully.");
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public List<ResultDTO> SortResultsByEventNameAscending()
        {
            List<ResultDTO> sortedResults = new List<ResultDTO>();

            // Construct the SQL query to retrieve results from the TeamResults table and sort them by event name in ascending order
            string query = "SELECT * FROM TeamResults ORDER BY EventName ASC";

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result set
                    SqlDataReader reader = command.ExecuteReader();

                    // Iterate through the result set and map each row to a ResultDTO object
                    while (reader.Read())
                    {
                        ResultDTO result = new ResultDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            EventName = reader["EventName"].ToString(),
                            GamePlayed = reader["GamePlayed"].ToString(),
                            Team = reader["Team"].ToString(),
                            OpposingTeam = reader["OpposingTeam"].ToString(),
                            Result = reader["Result"].ToString()
                        };

                        sortedResults.Add(result);
                    }

                    // Close the reader
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return sortedResults;
        }

        public List<ResultDTO> SortResultsByTeamNameAscending()
        {
            List<ResultDTO> sortedResults = new List<ResultDTO>();

            // Construct the SQL query to retrieve results from the TeamResults table and sort them by team name in ascending order
            string query = "SELECT * FROM TeamResults ORDER BY Team ASC";

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result set
                    SqlDataReader reader = command.ExecuteReader();

                    // Iterate through the result set and map each row to a ResultDTO object
                    while (reader.Read())
                    {
                        ResultDTO result = new ResultDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            EventName = reader["EventName"].ToString(),
                            GamePlayed = reader["GamePlayed"].ToString(),
                            Team = reader["Team"].ToString(),
                            OpposingTeam = reader["OpposingTeam"].ToString(),
                            Result = reader["Result"].ToString()
                        };

                        sortedResults.Add(result);
                    }

                    // Close the reader
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return sortedResults;
        }

        public void ExportResultsToCSV(List<ResultDTO> results, string fileName)
        {
            try
            {
                // Create a StringBuilder to hold CSV content
                StringBuilder csvContent = new StringBuilder();

                // Add headers to the CSV file
                csvContent.AppendLine("ID,EventName,GamePlayed,Team,OpposingTeam,Result");

                // Append each result to the CSV content
                foreach (ResultDTO result in results)
                {
                    csvContent.AppendLine($"{result.ID},{result.EventName},{result.GamePlayed},{result.Team},{result.OpposingTeam},{result.Result}");
                }

                // Define the path for the CSV file
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                // Write the CSV content to the file
                File.WriteAllText(filePath, csvContent.ToString());

                // Show success message to the user
               
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
            }
        }

        public void DeleteResultInfo(int id)
        {
            // Construct the SQL query to delete result information from the database
            string query = "DELETE FROM TeamResults WHERE ID = @ID";

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameter to the query to specify the ID of the result to delete
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and get the number of rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                        Console.WriteLine("Result information deleted successfully.");
                    else
                        Console.WriteLine("No result information found with the given ID.");
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void SaveUpdatedResultInfo(ResultDTO result)
        {
            string query = "UPDATE TeamResults SET EventName = @EventName, GamePlayed = @GamePlayed, Team = @Team, OpposingTeam = @OpposingTeam, Result = @Result WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EventName", result.EventName);
                command.Parameters.AddWithValue("@GamePlayed", result.GamePlayed);
                command.Parameters.AddWithValue("@Team", result.Team);
                command.Parameters.AddWithValue("@OpposingTeam", result.OpposingTeam);
                command.Parameters.AddWithValue("@Result", result.Result);
                command.Parameters.AddWithValue("@ID", result.ID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        Console.WriteLine("Result information updated successfully.");
                    else
                        Console.WriteLine("No result information found with the given ID.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public List<ResultDTO> MapResultData(KiddEsportsDataSet yourTableNameDataSet)
        {
            List<ResultDTO> resultList = new List<ResultDTO>();

            foreach (KiddEsportsDataSet.TeamResultsRow row in yourTableNameDataSet.TeamResults)
            {
                ResultDTO result = new ResultDTO
                {
                    EventName = row.EventName,
                    GamePlayed = row.GamePlayed,
                    Team = row.Team,
                    OpposingTeam = row.OpposingTeam,
                    Result = row.Result,
                    ID = Convert.ToInt32(row.ID)
                };

                resultList.Add(result);
            }

            return resultList;
        }

        public List<ResultDTO> SearchResultsByEventName(string eventName)
        {
            List<ResultDTO> foundResults = new List<ResultDTO>();

            string query = "SELECT * FROM TeamResults WHERE EventName LIKE @EventName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EventName", "%" + eventName + "%"); // Use LIKE operator for partial matches

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ResultDTO result = new ResultDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            EventName = reader["EventName"].ToString(),
                            GamePlayed = reader["GamePlayed"].ToString(),
                            Team = reader["Team"].ToString(),
                            OpposingTeam = reader["OpposingTeam"].ToString(),
                            Result = reader["Result"].ToString()
                        };

                        foundResults.Add(result);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return foundResults;
        }

        public int GetTotalResultRows()
        {
            int totalRows = 0;

            string query = "SELECT COUNT(*) FROM TeamResults";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    totalRows = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return totalRows;
        }

        /// <summary>
        /// Adds event information to the database.
        /// </summary>
        /// <param name="id">The ID of the event.</param>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventLocation">The location of the event.</param>
        /// <param name="eventDate">The date of the event.</param>
        public void AddEventInfo(string eventName, string eventLocation, string eventDate)
        {
            // SQL query to insert event information into the Event table
            string query = "INSERT INTO Event (EventName, EventLocation, EventDate) VALUES (@EventName, @EventLocation, @EventDate)";

            // Establish database connection and execute the command
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the query

                command.Parameters.AddWithValue("@EventName", eventName);
                command.Parameters.AddWithValue("@EventLocation", eventLocation);
                command.Parameters.AddWithValue("@EventDate", eventDate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Event information added successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Deletes event information from the database based on the provided ID.
        /// </summary>
        /// <param name="id">The ID of the event to delete.</param>
        public void DeleteEventInfo(int id)
        {
            // SQL query to delete event information from the Event table
            string query = "DELETE FROM Event WHERE ID = @ID";

            // Establish database connection and execute the command
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameter to the query
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        Console.WriteLine("Event information deleted successfully.");
                    else
                        Console.WriteLine("No event information found with the given ID.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Updates event information in the database.
        /// </summary>
        /// <param name="eventData">The EventDTO object containing updated event data.</param>
        public void SaveUpdatedEventInfo(EventDTO eventData)
        {
            // SQL query to update event information in the Event table
            string query = "UPDATE Event SET EventName = @EventName, EventLocation = @EventLocation, EventDate = @EventDate WHERE ID = @ID";

            // Establish database connection and execute the command
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the query
                command.Parameters.AddWithValue("@EventName", eventData.EventName);
                command.Parameters.AddWithValue("@EventLocation", eventData.EventLocation);
                command.Parameters.AddWithValue("@EventDate", eventData.EventDate);
                command.Parameters.AddWithValue("@ID", eventData.ID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        Console.WriteLine("Event information updated successfully.");
                    else
                        Console.WriteLine("No event information found with the given ID.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Retrieves the total number of rows in the Event table.
        /// </summary>
        /// <returns>The total number of rows in the Event table.</returns>
        public int GetTotalEventRows()
        {
            int totalRows = 0;

            // SQL query to count the total number of rows in the Event table
            string query = "SELECT COUNT(*) FROM Event";

            // Establish database connection and execute the command
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    totalRows = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return totalRows;
        }

        /// <summary>
        /// Maps event data from the provided dataset to a list of EventDTO objects.
        /// </summary>
        /// <param name="eventData">The dataset containing event data.</param>
        /// <returns>A list of EventDTO objects mapped from the dataset.</returns>
        public List<EventDTO> MapEventData(KiddEsportsDataSet eventData)
        {
            List<EventDTO> eventList = new List<EventDTO>();

            // Iterate through the dataset and map event data to EventDTO objects
            foreach (KiddEsportsDataSet.EventsRow row in eventData.Events)
            {
                EventDTO eventItem = new EventDTO
                {
                    EventName = row.EventName,
                    EventLocation = row.EventLocation,
                    EventDate = row.EventDate,
                    ID = row.ID
                };

                eventList.Add(eventItem);
            }

            return eventList;
        }


        public List<EventDTO> SortEventsByDate()
        {
            List<EventDTO> sortedEvents = new List<EventDTO>();

            string query = "SELECT * FROM Event ORDER BY EventDate ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        EventDTO eventItem = new EventDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            EventName = reader["EventName"].ToString(),
                            EventLocation = reader["EventLocation"].ToString(),
                            EventDate = reader["EventDate"].ToString()
                        };

                        sortedEvents.Add(eventItem);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return sortedEvents;
        }
        public List<EventDTO> SearchEventsByName(string searchTerm)
        {
            List<EventDTO> searchResults = new List<EventDTO>();

            string query = "SELECT * FROM Event WHERE EventName LIKE @SearchTerm";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        EventDTO eventItem = new EventDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            EventName = reader["EventName"].ToString(),
                            EventLocation = reader["EventLocation"].ToString(),
                            EventDate = reader["EventDate"].ToString()
                        };

                        searchResults.Add(eventItem);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return searchResults;
        }

        /// <summary>
        /// GAME Data
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="gameType"></param>
        public void AddGameInfo(string gameName, string gameType)
        {
            string query = "INSERT INTO GamePlayed (GameName, GameType) VALUES (@GameName, @GameType)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@GameName", gameName);
                command.Parameters.AddWithValue("@GameType", gameType);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Game information added successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }



        // Method to map game data
        public List<GameDTO> MapGameData(KiddEsportsDataSet GameListDataSet)
        {
            List<GameDTO> gameList = new List<GameDTO>();

            foreach (KiddEsportsDataSet.GamePlayedRow row in GameListDataSet.GamePlayed)
            {
                GameDTO game = new GameDTO
                {
                    GameName = row.GameName,
                    GameType = row.GameType,
                    ID = row.ID
                };

                gameList.Add(game);
            }

            return gameList;
        }
        ////////////
        /// <summary>
        /// NewGame
        /// </summary>
        /// <param name="team"></param>
        /// <param name="opposingTeam"></param>
        /// <param name="winner"></param>

        public void DeleteGamesPlayedInfo(int id)
        {
            string query = "DELETE FROM GamePlayed WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        Console.WriteLine("Game information deleted successfully.");
                    else
                        Console.WriteLine("No game information found with the given ID.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void SaveUpdatedGamesPlayedInfo(GamesPlayedDTO game)
        {
            string query = "UPDATE GamePlayed SET GameName = @GameName, GameType = @GameType WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GameName", game.GameName);
                command.Parameters.AddWithValue("@GameType", game.GameType);
                command.Parameters.AddWithValue("@ID", game.ID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        Console.WriteLine("Game information updated successfully.");
                    else
                        Console.WriteLine("No game information found with the given ID.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


        public void AddGameResult(string team, string opposingTeam, string result, string eventName, string gamePlayed)
        {
            // Construct the query to insert the game result into the database
            string query = "INSERT INTO TeamResults (EventName, GamePlayed, Team, OpposingTeam, Result) VALUES (@EventName, @GamePlayed, @Team, @OpposingTeam, @Result)";

            // Set the event name and game played (you may customize these based on your requirements)


            // Determine the result based on the winner



            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the query to prevent SQL injection attacks

                command.Parameters.AddWithValue("@EventName", eventName);
                command.Parameters.AddWithValue("@GamePlayed", gamePlayed);
                command.Parameters.AddWithValue("@Team", team);
                command.Parameters.AddWithValue("@OpposingTeam", opposingTeam);
                command.Parameters.AddWithValue("@Result", result);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Display success message
                    Console.WriteLine("Game result added to the database successfully.");
                }
                catch (Exception ex)
                {
                    // Display error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void UpdateTeamPoints(string team, int points)
        {
            // Construct the SQL query to update team points in the database
            string query = "UPDATE TeamInfo SET Points = Points + @Points WHERE TeamName = @Team";

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the query
                command.Parameters.AddWithValue("@Points", points);
                command.Parameters.AddWithValue("@Team", team);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Display error message if an exception occurs
                 
                }
            }
        }

    }
}