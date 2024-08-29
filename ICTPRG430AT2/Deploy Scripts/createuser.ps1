
# Define connection parameters
$serverName = "localhost"
$databaseName = "KiddEsports"
$newUsername = "NewUser2"    # << Enter Username Here
$newUserPassword = "NewPassword" # << Enter Password Here

# Connection string with SQL Authentication
$connectionString = "Server=$serverName;Database=$databaseName;User ID=ClassLibrary;Password=test;"

# SQL query to grant permissions to the new user
$sqlQuery = @"
USE $databaseName;
CREATE LOGIN $newUsername WITH PASSWORD = '$newUserPassword';
CREATE USER $newUsername FOR LOGIN $newUsername;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Event TO $newUsername;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.GamePlayed TO $newUsername;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.TeamInfo TO $newUsername;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.TeamResults TO $newUsername;
"@
try {
    $connection = New-Object System.Data.SqlClient.SqlConnection($connectionString)
    $connection.Open()
    $command = $connection.CreateCommand()
    $command.CommandText = $sqlQuery
    $command.ExecuteNonQuery()

    Write-Host "Permissions granted to user '$newUsername' successfully."
}
catch {
    Write-Host "Error occurred: $_.Exception.Message"
}
finally {
    $connection.Close()
}
