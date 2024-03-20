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
using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClassLibrary
{
    public partial class Results : Form
    {
        // Constructor
        public Results()
        {
            InitializeComponent();

            
            //Result.Items.Add("Win"); // Add Win / Loss Options
          //  Result.Items.Add("Loss");
            //Result.Items.Add("Draw");
            // Set default selection
           // Result.SelectedIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Results_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kiddEsportsData_View.TeamInfo' table. You can move, or remove it, as needed.
            this.teamInfoTableAdapter.Fill(this.kiddEsportsData_View.TeamInfo);
            // TODO: This line of code loads data into the 'kiddEsportsData_View.GamePlayed' table. You can move, or remove it, as needed.
            this.gamePlayedTableAdapter.Fill(this.kiddEsportsData_View.GamePlayed);
            // TODO: This line of code loads data into the 'kiddEsportsData_View.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.kiddEsportsData_View.Event);

            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);

        }



        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Menu();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Event();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Teams();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new NewGame();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Results();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }


        private void AlphabeticalSortBTN_Click(object sender, EventArgs e)
        {
            List<ResultDTO> sortedTeams = Program.DataMapper.SortResultsByEventNameAscending();

            // Update your DataGridView or any other control to display sortedTeams
            // For example:
            dataGridView1.DataSource = sortedTeams;
        }
        /*
        private void AddNewTeamBTN_Click(object sender, EventArgs e)
        {
            int points = 0;
            int oppositPoints = 0;
            // Get values from your WinForms controls
            string eventName = EventName.SelectedValue != null ? EventName.SelectedValue.ToString() : string.Empty;
            string gamePlayed = GamePlayed.SelectedValue != null ? GamePlayed.SelectedValue.ToString() : string.Empty;
            string team = Team.SelectedValue != null ? Team.SelectedValue.ToString() : string.Empty;
            string opposingTeam = OpposingTeam.SelectedValue != null ? OpposingTeam.SelectedValue.ToString() : string.Empty;
            string result = Result.SelectedItem != null ? Result.SelectedItem.ToString() : string.Empty;
            if (opposingTeam == team)
            {
                MessageBox.Show("Competing Teams Can Not Be The Same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string oppositeResult = result == "Win" ? "Loss" : "Win";
            if (oppositeResult == "Win")
            {
                oppositPoints = 2;
                points = -2;
            }
            if(oppositeResult == "Loss")
            {
                oppositPoints = -2;
                points = 2;
            }
            else
            {
                return;
            }
            // Call the update method
            Program.DataMapper.AddResultInfo(eventName, gamePlayed, team, opposingTeam, result);
            Program.DataMapper.UpdateTeamPoints(team, points);
            Program.DataMapper.UpdateTeamPoints(opposingTeam, oppositPoints);
            // Add the opposite result for the opposing team

            Program.DataMapper.AddResultInfo(eventName, gamePlayed, opposingTeam, team, oppositeResult);

            // Refresh the team results table
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);
        }
        */


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the update section with data from the selected row
                IDTXT.Text = row.Cells["IDColumn"].Value.ToString();
                EventNameTXT.Text = row.Cells["EventNameColumn"].Value.ToString();
                GamePlayedTXT.Text = row.Cells["GamePlayedColumn"].Value.ToString();
                TeamTXT.Text = row.Cells["TeamColumn"].Value.ToString();
                OpposingTeamTXT.Text = row.Cells["OpposingTeamColumn"].Value.ToString();
                ResultTXT.Text = row.Cells["ResultColumn"].Value.ToString();

            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(DeleteID.Text))
            {
                MessageBox.Show("Please provide an Result ID to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }
            int id = Convert.ToInt32(DeleteID.Text);
            // Call the delete method
            Program.DataMapper.DeleteResultInfo(id);
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);

            DeleteID.ResetText();
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string resultIdToUpdate = IDTXT.Text != null ? IDTXT.Text.ToString() : string.Empty;
                int resultID = Convert.ToInt32(resultIdToUpdate);

                // Error Handling 
                string eventName = EventNameTXT.Text != null ? EventNameTXT.Text.ToString() : string.Empty;
                string gamePlayed = GamePlayedTXT.Text != null ? GamePlayedTXT.Text.ToString() : string.Empty;
                string team = TeamTXT.Text != null ? TeamTXT.Text.ToString() : string.Empty;

                string opposingTeam = OpposingTeamTXT.Text != null ? OpposingTeamTXT.Text.ToString() : string.Empty;
                string result = ResultTXT.Text != null ? ResultTXT.Text.ToString() : string.Empty;

                ResultDTO updatedResultData = new ResultDTO
                {
                    ID = resultID,
                    EventName = eventName,
                    GamePlayed = gamePlayed,
                    Team = team,
                    OpposingTeam = opposingTeam,
                    Result = result
                };

                // Call the SaveUpdatedResultInfo method to update the result information
                Program.DataMapper.SaveUpdatedResultInfo(updatedResultData);
                this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: Wrong Input, Ensure input is a whole number", $"Error: {ex}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTxtResults.Text; // Get the search term from the text box

            // Call the SearchEventsByName method from the DataMapper class
            List<ResultDTO> searchResults = Program.DataMapper.SearchResultsByEventName(searchTerm);
            SearchTxtResults.ResetText();
            // Display the search results in your UI
            // For example, you can populate a DataGridView with the search results
            dataGridView1.DataSource = searchResults;
        }

        // triggered when the user clicks a button to sort results by event name.
        private void SortByEventResults_Click(object sender, EventArgs e)
        {
            // Retrieve sorted results by event name in ascending order
            List<ResultDTO> sortedResults = Program.DataMapper.SortResultsByEventNameAscending();

            // Bind the sorted results to a dataGridView1 for display
            dataGridView1.DataSource = sortedResults;
        }

        // triggered when the user clicks a button to sort results by team name.
        private void SortByTeamNameResults_Click(object sender, EventArgs e)
        {
            // Retrieve sorted results by team name in ascending order
            List<ResultDTO> sortedResults = Program.DataMapper.SortResultsByTeamNameAscending();

            // Bind the sorted results to a dataGridView1 for display
            dataGridView1.DataSource = sortedResults;
        }

        // triggered when the user clicks a button to export sorted results by event name to a CSV file.
        private void ExportBTNResults_Click(object sender, EventArgs e)
        {
            // Retrieve sorted results by event name in ascending order
            List<ResultDTO> sortedResults = Program.DataMapper.SortResultsByEventNameAscending();

            // Export the sorted results to a CSV file named "SortedResultsByEventName.csv"
            Program.DataMapper.ExportResultsToCSV(sortedResults, "SortedResultsByEventName.csv");
            MessageBox.Show("Export Completed to desktop", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This method is triggered when the user clicks a button to export sorted results by team name to a CSV file.
        private void ExportTeamName_Click(object sender, EventArgs e)
        {
            // Retrieve sorted results by team name in ascending order
            List<ResultDTO> sortedResults = Program.DataMapper.SortResultsByTeamNameAscending();

            // Export the sorted results to a CSV file named "SortedResultsByTeamName.csv"
            Program.DataMapper.ExportResultsToCSV(sortedResults, "SortedResultsByTeamName.csv");
            MessageBox.Show("Export Completed to desktop", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
