using ClassLibrary;
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

namespace ClassLibrary
{
    public partial class NewGame : Form
    {
        // Constructor
        public NewGame()
        {
            // Initialize form components
            InitializeComponent();
            GameType.Items.Add("Solos"); // Add Game Type Options
            GameType.Items.Add("Duos");
            GameType.Items.Add("Squads");
            // Set default selection
            GameType.SelectedIndex = 0;
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
            string gameType = GameType.SelectedItem != null ? GameType.SelectedItem.ToString() : string.Empty;
            // Retrieve the entered game name
            string gameName = NewGameNameTXT.Text;
            string EventName = NewGameEventDropdown.SelectedValue != null ? NewGameEventDropdown.SelectedItem.ToString() : string.Empty;

            // Error Handling

            if (string.IsNullOrWhiteSpace(gameType) ||
                string.IsNullOrWhiteSpace(gameName) ||
                string.IsNullOrWhiteSpace(EventName)) // If Empty
            {
                MessageBox.Show("Please fill in all fields before adding a new team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (TeamComboBox.SelectedValue == OpposingTeamComboBox.SelectedValue)  // If same teams versing
            {
                MessageBox.Show("Competing Teams Can Not Be The Same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TeamComboBox.SelectedValue != WinnerComboBox.SelectedValue) // if winner not competing
            {
                if (OpposingTeamComboBox.SelectedValue != WinnerComboBox.SelectedValue)
                {
                    MessageBox.Show("Winner is not competing!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Add the new game information to the database
            Program.DataMapper.AddGameInfo(gameName, gameType);
            // Refresh the GamesPlayed DataGridView to reflect the changes
            this.gamesPlayedTableAdapter.Fill(this.kiddEsportsData.GamePlayed);

          

            // Retrieve the selected teams and winner, and the event name
            string team = TeamComboBox.SelectedValue != null ? TeamComboBox.SelectedValue.ToString() : string.Empty;
            string opposingTeam = OpposingTeamComboBox.SelectedValue != null ? OpposingTeamComboBox.SelectedValue.ToString() : string.Empty;
            string winner = WinnerComboBox.SelectedValue != null ? WinnerComboBox.SelectedValue.ToString() : string.Empty;
            string eventName = NewGameEventDropdown.SelectedValue != null ? NewGameEventDropdown.SelectedValue.ToString() : string.Empty;
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
                    opposingpoints = -2;
                }
                else if (opposingTeam == winner)
                {
                    result = "Loss";
                    opposingpoints = -2; // Opposing team gets 2 points
                    opposingresult = "Win";
                }
            }

            
            // Add the game result to the database for both teams
            Program.DataMapper.AddGameResult(team, opposingTeam, result, eventName, gameName);
            Program.DataMapper.AddGameResult(opposingTeam, team, opposingresult, eventName, gameName);
            // Refresh the TeamResults DataGridView to reflect the changes
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);

            // Update team points in the database
            Program.DataMapper.UpdateTeamPoints(team, points);
            Program.DataMapper.UpdateTeamPoints(opposingTeam, opposingpoints);

            // Refresh the TeamInfo DataGridView to reflect the changes
            this.teamInfoTableAdapter.Fill(this.kiddEsportsData.TeamInfo);

            // Clear input fields after updating team information
           
            NewGameNameTXT.ResetText();
            TeamComboBox.SelectedIndex = -1;
            OpposingTeamComboBox.SelectedIndex = -1;
            WinnerComboBox.SelectedIndex = -1;
            NewGameEventDropdown.SelectedIndex = -1;
        }

        // Button click event handler for updating a game
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            var gameIdToUpdate = new int();
            var updateIdString = UpdateIDCombobox.SelectedValue != null ? UpdateIDCombobox.SelectedValue.ToString() : string.Empty;


            string GameName = UpdateGameNameTXT.Text;
            string GameType = UpdateGameTypeTXT.Text;
           

            if (string.IsNullOrWhiteSpace(GameName) ||
            string.IsNullOrWhiteSpace(GameType))
            {
                MessageBox.Show("Please fill in all fields before adding a new team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // Retrieve the game ID to update
            int.TryParse(updateIdString, out gameIdToUpdate);

            // Create a GamesPlayedDTO object with updated game information
            GamesPlayedDTO updatedGameData = new GamesPlayedDTO
            {
                ID = gameIdToUpdate,
                GameName = UpdateGameNameTXT.Text,
                GameType = UpdateGameTypeTXT.Text
            };

            // Update the game information in the database
            Program.DataMapper.SaveUpdatedGamesPlayedInfo(updatedGameData);

            // Refresh the GamesPlayed DataGridView to reflect the changes
            this.gamesPlayedTableAdapter.Fill(this.kiddEsportsData.GamePlayed);
        }

        // Button click event handler for deleting a game
        private void GameDeleteBTN_Click(object sender, EventArgs e)
        {
            // Retrieve the game ID to delete
            int.TryParse(DeleteGameID.Text, out int id);

            if (id == 0) return;
            
          
            // Delete the game information from the database
            Program.DataMapper.DeleteGamesPlayedInfo(id);
            // Refresh the GamesPlayed DataGridView to reflect the changes
            this.gamesPlayedTableAdapter.Fill(this.kiddEsportsData.GamePlayed);
            DeleteGameID.ResetText();
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

            using (SqlConnection connection = new SqlConnection(Program.DataMapper.DboConnectionString))
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