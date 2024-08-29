# Define SQL query to create the database
$sqlCreateDatabase = @"
IF NOT EXISTS (
    SELECT name
    FROM sys.databases
    WHERE name = 'KiddEsports'
)
BEGIN
    CREATE DATABASE KiddEsports;
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

    # Execute the SQL query to create the database
    $sqlCommand.CommandText = $sqlCreateDatabase
    $sqlCommand.ExecuteNonQuery()

    Write-Host "Database 'KiddEsports' created successfully."

} catch {
    Write-Host "Error: $_"
} finally {
    # Close the SQL Server connection
    $sqlConnection.Close()
}
