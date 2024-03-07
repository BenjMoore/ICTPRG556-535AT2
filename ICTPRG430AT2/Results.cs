using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace ICTPRG430AT2
{
    public partial class Results : Form
    {
        private DataMapper dataMapper;
        string connectionString = Properties.Settings.Default.ConnectionString;
        public Results()
        {
            InitializeComponent();
            dataMapper = new DataMapper(connectionString);
        }

        private void Results_Load(object sender, EventArgs e)
        {
          
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
            List<ResultDTO> sortedTeams = dataMapper.SortResultsByEventNameAscending();

            // Update your DataGridView or any other control to display sortedTeams
            // For example:
            dataGridView1.DataSource = sortedTeams;
        }

        private void AddNewTeamBTN_Click(object sender, EventArgs e)
        {
            // Get values from your WinForms controls
            string eventName = EventNametxt.Text;
            string gamePlayed = GamePlayedtxt.Text;
            string team = Teamtxt.Text;
            string opposingTeam = OpposingTeamtxt.Text;
            string result = Resulttxt.Text;

            // Call the update method
            dataMapper.AddResultInfo(eventName, gamePlayed, team, opposingTeam, result);
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);

            EventNametxt.ResetText();
            GamePlayedtxt.ResetText();
            Teamtxt.ResetText();
            OpposingTeamtxt.ResetText();
            Resulttxt.ResetText();
        }



        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DeleteID.Text);

            // Call the delete method
            dataMapper.DeleteResultInfo(id);
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);

            DeleteID.ResetText();
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            int resultIdToUpdate = Convert.ToInt32(ReturnID.Text);
            ResultDTO updatedResultData = new ResultDTO
            {
                ID = resultIdToUpdate,
                EventName = ReturnEventName.Text,
                GamePlayed = ReturnGamePlayed.Text,
                Team = ReturnTeam.Text,
                OpposingTeam = ReturnOpposingTeam.Text,
                Result = ReturnResult.Text
            };
            ReturnEventName.ResetText();
            ReturnGamePlayed.ResetText();
            ReturnTeam.ResetText();
            ReturnOpposingTeam.ResetText();
            ReturnResult.ResetText();
            ReturnID.ResetText();
            // Call the SaveUpdatedResultInfo method to update the result information
            dataMapper.SaveUpdatedResultInfo(updatedResultData);
            this.teamResultsTableAdapter.Fill(this.kiddEsportsData.TeamResults);
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTxtResults.Text; // Get the search term from the text box

            // Call the SearchEventsByName method from the DataMapper class
            List<ResultDTO> searchResults = dataMapper.SearchResultsByEventName(searchTerm);
            SearchTxtResults.ResetText();
            // Display the search results in your UI
            // For example, you can populate a DataGridView with the search results
            dataGridView1.DataSource = searchResults;
        }

        // triggered when the user clicks a button to sort results by event name.
        private void SortByEventResults_Click(object sender, EventArgs e)
        {
            // Retrieve sorted results by event name in ascending order
            List<ResultDTO> sortedResults = dataMapper.SortResultsByEventNameAscending();

            // Bind the sorted results to a dataGridView1 for display
            dataGridView1.DataSource = sortedResults;
        }

        // triggered when the user clicks a button to sort results by team name.
        private void SortByTeamNameResults_Click(object sender, EventArgs e)
        {
            // Retrieve sorted results by team name in ascending order
            List<ResultDTO> sortedResults = dataMapper.SortResultsByTeamNameAscending();

            // Bind the sorted results to a dataGridView1 for display
            dataGridView1.DataSource = sortedResults;
        }

        // triggered when the user clicks a button to export sorted results by event name to a CSV file.
        private void ExportBTNResults_Click(object sender, EventArgs e)
        {
            // Retrieve sorted results by event name in ascending order
            List<ResultDTO> sortedResults = dataMapper.SortResultsByEventNameAscending();

            // Export the sorted results to a CSV file named "SortedResultsByEventName.csv"
            dataMapper.ExportResultsToCSV(sortedResults, "SortedResultsByEventName.csv");
            MessageBox.Show($"Teams exported to CSV successfully");
        }

        // This method is triggered when the user clicks a button to export sorted results by team name to a CSV file.
        private void ExportTeamName_Click(object sender, EventArgs e)
        {
            // Retrieve sorted results by team name in ascending order
            List<ResultDTO> sortedResults = dataMapper.SortResultsByTeamNameAscending();

            // Export the sorted results to a CSV file named "SortedResultsByTeamName.csv"
            dataMapper.ExportResultsToCSV(sortedResults, "SortedResultsByTeamName.csv");
            MessageBox.Show($"Teams exported to CSV successfully");
        }

    }
}
