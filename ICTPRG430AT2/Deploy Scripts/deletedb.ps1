# Define the database name
$databaseName = "KiddEsports"

# Connection string
$connectionString = "Data Source=localhost;Integrated Security=True;TrustServerCertificate=True;"

Write-Host "Connection string: $connectionString"

# Create a SQL Server connection
$sqlConnection = New-Object System.Data.SqlClient.SqlConnection
$sqlConnection.ConnectionString = $connectionString

# Create a SQL command to execute the query
$sqlCommand = New-Object System.Data.SqlClient.SqlCommand
$sqlCommand.Connection = $sqlConnection

try {
    # Open the SQL Server connection
    $sqlConnection.Open()

    # Define SQL query to drop the database
    $sqlDropDatabase = "IF EXISTS (SELECT * FROM sys.databases WHERE name = '$databaseName') BEGIN DROP DATABASE $databaseName; END;"

    Write-Host "Deleting database '$databaseName'..."

    # Execute the SQL query to drop the database
    $sqlCommand.CommandText = $sqlDropDatabase
    $sqlCommand.ExecuteNonQuery()

    Write-Host "Database '$databaseName' deleted successfully."

} catch {
    Write-Host "Error: $_"
} finally {
    # Close the SQL Server connection
    $sqlConnection.Close()
}
