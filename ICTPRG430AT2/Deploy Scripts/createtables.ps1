# Define SQL query to create tables
$sqlCreateTables = @"
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
END;

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
END;

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Event')
BEGIN
    CREATE TABLE Event (
        ID INT PRIMARY KEY IDENTITY(1,1),
        EventName VARCHAR(50),
        EventLocation VARCHAR(50),
        EventDate VARCHAR(50)
    );
END;

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'GamePlayed')
BEGIN
    CREATE TABLE GamePlayed (
        ID INT PRIMARY KEY IDENTITY(1,1),
        GameName VARCHAR(50),
        GameType VARCHAR(50)
    );
END;
"@

# SQL Server connection settings

$connectionString = "Data Source=localhost;Integrated Security=True;TrustServerCertificate=True"

# Create a SQL Server connection
$sqlConnection = New-Object System.Data.SqlClient.SqlConnection
$sqlConnection.ConnectionString = $connectionString

# Create a SQL command to execute the query
$sqlCommand = New-Object System.Data.SqlClient.SqlCommand
$sqlCommand.Connection = $sqlConnection

try {
    # Open the SQL Server connection
    $sqlConnection.Open()

    # Execute the SQL query to create the tables
    $sqlCommand.CommandText = $sqlCreateTables
    $sqlCommand.ExecuteNonQuery()

    Write-Host "Tables created successfully."

} catch {
    Write-Host "Error: $_"
} finally {
    # Close the SQL Server connection
    $sqlConnection.Close()
}
