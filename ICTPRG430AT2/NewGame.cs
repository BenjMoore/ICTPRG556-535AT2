﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ICTPRG430AT2
{
    public partial class NewGame : Form
    {
        // DataMapper instance to handle database operations
        private DataMapper dataMapper;
        // Connection string for database connection
        string connectionString = Properties.Settings.Default.ConnectionString;

        // Constructor
        public NewGame()
        {
            // Initialize DataMapper with the provided connection string
            dataMapper = new DataMapper(connectionString);
            // Initialize form components
            InitializeComponent();
        }

        // Form Load event handler
        private void NewGame_Load(object sender, EventArgs e)
        {
            // Load data into the TeamResults DataGridView
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);
            // Load data into the TeamInfo DataGridView
            this.teamInfoTableAdapter.Fill(this.kiddEsportsData.TeamInfo);
            // Load data into the Events DataGridView
            this.eventsTableAdapter.Fill(this.kiddEsportsData.Events);
            // Load data into the GamesPlayed DataGridView
            this.gamesPlayedTableAdapter.Fill(this.kiddEsportsData.GamePlayed);
        }

        // Button click event handler for returning to the main menu
        private void button4_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();
            // Instantiate the Menu form
            var form2 = new Menu();
            // Add an event handler for the Menu form's close event
            form2.Closed += (s, args) => this.Close();
            // Show the Menu form
            form2.Show();
        }

        // Button click event handler for adding a new game
        private void NewGameBTN_Click(object sender, EventArgs e)
        {
            // Generate a new game ID
            int ID = GetNewGameID();
            // Retrieve the selected game type
            string gameType = NewGameTypeDropdown.Text;
            // Retrieve the entered game name
            string gameName = NewGameNameTXT.Text;
            // Add the new game information to the database
            dataMapper.AddGameInfo(gameName, gameType);
            // Refresh the GamesPlayed DataGridView to reflect the changes
            this.gamesPlayedTableAdapter.Fill(this.kiddEsportsData.GamePlayed);

            // Retrieve the selected teams and winner, and the event name
            string team = TeamComboBox.SelectedValue.ToString();
            string opposingTeam = OpposingTeamComboBox.SelectedValue.ToString();
            string winner = WinnerComboBox.SelectedValue.ToString();
            string eventName = NewGameEventDropdown.SelectedValue.ToString();
            string result = "Draw";
            string opposingresult = "Draw";
            int points = 0; // Initialize points for the winning team
            int opposingpoints = 0; // Initialize points for the opposing team
            if (DrawCheckBox.Checked)
            {
                result = "Draw";
                opposingresult = "Draw";
                points = 1; // Both teams get 1 point for a draw
                opposingpoints = 1;
            }
            // Determine the result based on the winner
            else if (!DrawCheckBox.Checked)
            {
                if (team == winner)
                {
                    result = "Win";
                    opposingresult = "Loss";
                    points = 2; // Winning team gets 2 points
                }
                else if (opposingTeam == winner)
                {
                    result = "Loss";
                    opposingpoints = 2; // Opposing team gets 2 points
                    opposingresult = "Win";
                }
            }

            // Add the game result to the database for both teams
            dataMapper.AddGameResult(team, opposingTeam, result, eventName, gameName);
            dataMapper.AddGameResult(opposingTeam, team, opposingresult, eventName, gameName);
            // Refresh the TeamResults DataGridView to reflect the changes
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);

            // Update team points in the database
            dataMapper.UpdateTeamPoints(team, points);
            dataMapper.UpdateTeamPoints(opposingTeam, opposingpoints);

            // Refresh the TeamInfo DataGridView to reflect the changes
            this.teamInfoTableAdapter.Fill(this.kiddEsportsData.TeamInfo);

            // Clear input fields after updating team information
            NewGameTypeDropdown.ResetText();
            NewGameNameTXT.ResetText();
            TeamComboBox.SelectedIndex = -1;
            OpposingTeamComboBox.SelectedIndex = -1;
            WinnerComboBox.SelectedIndex = -1;
            NewGameEventDropdown.SelectedIndex = -1;
        }

        // Button click event handler for updating a game
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            // Retrieve the game ID to update
            int gameIdToUpdate = Convert.ToInt32(UpdateIDCombobox.SelectedValue.ToString());
            // Create a GamesPlayedDTO object with updated game information
            GamesPlayedDTO updatedGameData = new GamesPlayedDTO
            {
                ID = gameIdToUpdate,
                GameName = UpdateGameNameTXT.Text,
                GameType = UpdateGameTypeTXT.Text
            };

            // Update the game information in the database
            dataMapper.SaveUpdatedGamesPlayedInfo(updatedGameData);

            // Refresh the GamesPlayed DataGridView to reflect the changes
            this.gamesPlayedTableAdapter.Fill(this.kiddEsportsData.GamePlayed);
        }

        // Button click event handler for deleting a game
        private void GameDeleteBTN_Click(object sender, EventArgs e)
        {
            // Retrieve the game ID to delete
            int id = Convert.ToInt32(DeleteGameID.Text);
            // Delete the game information from the database
            dataMapper.DeleteGamesPlayedInfo(id);
            // Refresh the GamesPlayed DataGridView to reflect the changes
            this.gamesPlayedTableAdapter.Fill(this.kiddEsportsData.GamePlayed);
        }

        // Method to get a new game ID
        private int GetNewGameID()
        {
            return GetNewGameID("ID");
        }

        private int GetNewGameID(string columnName)
        {
            int newID = 0;

            // SQL query to get the maximum game ID from the database
            string query = $"SELECT MAX({columnName}) FROM GamePlayed";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    // Execute the query and retrieve the result
                    object result = command.ExecuteScalar();
                    // Check if the result is not null
                    if (result != DBNull.Value)
                    {
                        // Increment the maximum ID by 1 to get a new ID
                        newID = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        // If no records are found, set the new ID to 1
                        newID = 1;
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            // Return the new game ID
            return newID;
        }

    }
}