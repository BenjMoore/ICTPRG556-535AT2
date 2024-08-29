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
using ICTPRG430AT2;
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
            // In your form load or initialization method, populate the ResultCombo with the options


        }

        private void Results_Load(object sender, EventArgs e)
        {

            this.teamResultsTableAdapter1.Fill(this.kiddEsportsData_View.TeamResults);
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);
            var team1Data = new KiddEsportsData_View.TeamInfoDataTable();
            var team2Data = new KiddEsportsData_View.TeamInfoDataTable();
            var resultData = new KiddEsportsData_View.TeamInfoDataTable();
            var gameData = new KiddEsportsData_View.GamePlayedDataTable();
            var eventData = new KiddEsportsData_View.EventDataTable();

            teamInfoTableAdapter.Fill(team1Data);
            teamInfoTableAdapter.Fill(team2Data);
            teamInfoTableAdapter.Fill(resultData);
            eventTableAdapter.Fill(eventData);
            gamePlayedTableAdapter.Fill(gameData);

            // Bind each combo box to its own data source
            Team.DataSource = team1Data;
            Team.DisplayMember = "TeamName";
            Team.ValueMember = "TeamName";

            OpposingTeam.DataSource = team2Data;
            OpposingTeam.DisplayMember = "TeamName";
            OpposingTeam.ValueMember = "TeamName";

            Result.DataSource = resultData;
            Result.DisplayMember = "TeamName";
            Result.ValueMember = "TeamName";

            GamePlayed.DataSource = gameData;
            GamePlayed.DisplayMember = "GameName";
            GamePlayed.ValueMember = "GameName";


            EventName.DataSource = eventData;
            EventName.DisplayMember = "EventName";
            EventName.ValueMember = "EventName";


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
                EventName.SelectedValue = row.Cells["EventNameColumn"].Value.ToString();
                GamePlayed.SelectedValue = row.Cells["GamePlayedColumn"].Value.ToString();
                Team.SelectedValue = row.Cells["TeamColumn"].Value.ToString();
                OpposingTeam.SelectedValue = row.Cells["OpposingTeamColumn"].Value.ToString();
                Result.SelectedValue = row.Cells["ResultColumn"].Value.ToString();
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string resultIdToUpdate = IDTXT.Text != null ? IDTXT.Text.ToString() : string.Empty;
                int resultID = Convert.ToInt32(resultIdToUpdate);
                ResultDTO currentresult = Program.DataMapper.GetResultByID(resultID);

                // Get the selected values from combo boxes
                string eventName = EventName.SelectedValue != null ? EventName.SelectedValue.ToString() : string.Empty;
                string gamePlayed = GamePlayed.SelectedValue != null ? GamePlayed.SelectedValue.ToString() : string.Empty;
                string team = Team.SelectedValue != null ? Team.SelectedValue.ToString() : string.Empty;
                string opposingTeam = OpposingTeam.SelectedValue != null ? OpposingTeam.SelectedValue.ToString() : string.Empty;
                string result = Result.SelectedValue != null ? Result.SelectedValue.ToString() : string.Empty;

                ResultDTO updatedResultData = new ResultDTO
                {
                    ID = resultID,
                    EventName = eventName,
                    GamePlayed = gamePlayed,
                    Team = team,
                    OpposingTeam = opposingTeam,
                    Result = result
                };

                if (currentresult.Result != null)
                {
                    if (updatedResultData.Result != currentresult.Result)
                    {
                        if (updatedResultData.Team == updatedResultData.Result || updatedResultData.OpposingTeam == updatedResultData.Result)
                        {
                            int points = Program.DataMapper.GetTeamPoints(currentresult.Result);
                            if (points < 0)
                            {
                                // Display a warning message to the user
                                DialogResult dialogResult = MessageBox.Show($"Warning: {currentresult.Result} will have zero or less points once this is complete.\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                // Check the user's choice
                                if (dialogResult == DialogResult.No)
                                {
                                    // User chose not to continue, return without further processing
                                    return;
                                }
                            }

                            // Update points and save result info
                            Program.DataMapper.UpdateTeamPoints(currentresult.Result, -2);
                            Program.DataMapper.UpdateTeamPoints(updatedResultData.Result, 2);
                            Program.DataMapper.SaveUpdatedResultInfo(updatedResultData);

                            // Refresh the team results table
                            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);
                        }
                        else
                        {
                            // Display an error message indicating that the winner did not compete
                            MessageBox.Show($"Error: {updatedResultData.Result} did not compete.\nTeam: {updatedResultData.Team}\nOpposing Team: {updatedResultData.OpposingTeam}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Save the updated result info
                        Program.DataMapper.SaveUpdatedResultInfo(updatedResultData);
                        this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dataGridView1.DataSource = sortedResults;
            MessageBox.Show("Export Completed to desktop", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This method is triggered when the user clicks a button to export sorted results by team name to a CSV file.
        private void ExportTeamName_Click(object sender, EventArgs e)
        {
            // Retrieve sorted results by team name in ascending order
            List<ResultDTO> sortedResults = Program.DataMapper.SortResultsByTeamNameAscending();
            dataGridView1.DataSource = sortedResults;
            // Export the sorted results to a CSV file named "SortedResultsByTeamName.csv"
            Program.DataMapper.ExportResultsToCSV(sortedResults, "SortedResultsByTeamName.csv");
            MessageBox.Show("Export Completed to desktop", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EventReportBTN_Click(object sender, EventArgs e)
        {
            List<ResultDTO> sortedResults = Program.DataMapper.SortResultsByTeamNameAscending();
            dataGridView1.DataSource = sortedResults;
        }

        private void TeamReportBTN_Click(object sender, EventArgs e)
        {
            List<ResultDTO> sortedResults = Program.DataMapper.SortResultsByTeamNameAscending();
            dataGridView1.DataSource = sortedResults;
        }
        private void LoadDataGridView()
        {
            // Fetch the data from the database and set it as the data source of the DataGridView
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);
        }
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.DataMapper.GetResultsFromDatabase();
        }
    }
}
