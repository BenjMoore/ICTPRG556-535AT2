# Database credentials
$serverName = "YourServerName"
$databaseName = "KiddEsports"
$username = "YourUsername"
$password = "YourPassword"

# SQL script to drop the database
$dropDatabaseScript = "USE master; DROP DATABASE IF EXISTS $databaseName;"

# Execute SQL script to drop the database
try {
    sqlcmd -S $serverName -U $username -P $password -Q $dropDatabaseScript
    Write-Host "Database $databaseName deleted successfully."
} catch {
    Write-Host "Error deleting database $databaseName: $_"
}
