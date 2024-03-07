using ClassLibrary;
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

namespace ICTPRG430AT2
{
    public partial class Teams : Form
    {
        // DataMapper instance to handle database operations
        private DataMapper dataMapper;
        // Connection string for database connection
        string connectionString = Properties.Settings.Default.ConnectionString;

        // Constructor
        public Teams()
        {
            // Initialize form components
            InitializeComponent();
            // Initialize DataMapper with the provided connection string

            dataMapper = new DataMapper(connectionString);
        }

      
        // Form Load event handler
        private void Teams_Load(object sender, EventArgs e)
        {
            // Load data into the TeamInfo DataGridView
            this.teamInfoTableAdapter.Fill(this.kiddEsportsData.TeamInfo);
        }

        // Button click event handler for navigating to the home page
        private void Homebtn_Click(object sender, EventArgs e)
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

        // Button click event handler for navigating to the Events page
        private void button1_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();
            // Instantiate the Event form
            var form2 = new Event();
            // Add an event handler for the Event form's close event
            form2.Closed += (s, args) => this.Close();
            // Show the Event form
            form2.Show();
        }

        // Button click event handler for reloading the Teams page
        private void button2_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();
            // Instantiate the Teams form
            var form2 = new Teams();
            // Add an event handler for the Teams form's close event
            form2.Closed += (s, args) => this.Close();
            // Show the Teams form
            form2.Show();
        }

        // Button click event handler for navigating to the NewGame page
        private void button3_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();
            // Instantiate the NewGame form
            var form2 = new NewGame();
            // Add an event handler for the NewGame form's close event
            form2.Closed += (s, args) => this.Close();
            // Show the NewGame form
            form2.Show();
        }

        // Button click event handler for navigating to the Results page
        private void button4_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();
            // Instantiate the Results form
            var form2 = new Results();
            // Add an event handler for the Results form's close event
            form2.Closed += (s, args) => this.Close();
            // Show the Results form
            form2.Show();
        }

        // Button click event handler for adding a new team
        private void AddNewTeamBTN_Click(object sender, EventArgs e)
        {
            // Generate a new team ID
           
            // Retrieve values from WinForms controls
            string teamName = TeamNameTxt.Text;
            string primaryContact = PrimaryContactTxt.Text;
            string contactEmail = ContactEmail.Text;
            string points = PointsTxt.Text;

            // Call the AddTeamInfo method in DataMapper to add the new team
            dataMapper.AddTeamInfo(teamName, primaryContact, contactEmail, points);
            // Refresh the TeamInfo DataGridView to reflect the changes
            this.teamInfoTableAdapter.Fill(this.kiddEsportsData.TeamInfo);

            // Clear input fields after adding a new team
            TeamNameTxt.ResetText();
            PrimaryContactTxt.ResetText();
            ContactEmail.ResetText();
            PointsTxt.ResetText();
        }

        // Button click event handler for deleting a team
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            // Retrieve the ID of the team to delete
            int id = Convert.ToInt32(DeleteID.Text);
            // Call the DeleteTeamInfo method in DataMapper to delete the team
            dataMapper.DeleteTeamInfo(id);
            // Clear the DeleteID field after deleting the team
            DeleteID.ResetText();
            // Refresh the TeamInfo DataGridView to reflect the changes
            this.teamInfoTableAdapter.Fill(this.kiddEsportsData.TeamInfo);
        }

        // Button click event handler for sorting teams by points
        private void PointsSortBTN_Click(object sender, EventArgs e)
        {
            // Call the SortTeamsByPoints method in DataMapper to sort teams by points
            List<TeamDTO> sortedTeams = dataMapper.SortTeamsByPoints();
            // Set the DataSource of the DataGridView to display the sorted teams
            dataGridView1.DataSource = sortedTeams;
        }

        // Button click event handler for sorting teams alphabetically
        private void AlphabeticalSortBTN_Click(object sender, EventArgs e)
        {
            // Call the SortTeamsAlphabetically method in DataMapper to sort teams alphabetically
            List<TeamDTO> sortedTeams = dataMapper.SortTeamsAlphabetically();
            // Set the DataSource of the DataGridView to display the sorted teams
            dataGridView1.DataSource = sortedTeams;
        }

        // Button click event handler for updating team information
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            // Retrieve the ID of the team to update
            int idToUpdate = Convert.ToInt32(ReturnID.Text);
            // Create a new TeamDTO object with updated values
            TeamDTO updatedTeamData = new TeamDTO
            {
                ID = idToUpdate,
                TeamName = ReturnName.Text,
                PrimaryContact = ReturnContact.Text,
                ContactEmail = ReturnEmail.Text,
                Points = Convert.ToInt32(ReturnPoints.Text)
            };
            // Call the SaveUpdatedTeamInfo method in DataMapper to update the team information
            dataMapper.SaveUpdatedTeamInfo(updatedTeamData);
            // Refresh the TeamInfo DataGridView to reflect the changes
            this.teamInfoTableAdapter.Fill(this.kiddEsportsData.TeamInfo);
            // Clear input fields after updating team information
            ReturnID.Text = "";
            ReturnName.Text = "";
            ReturnEmail.Text = "";
            ReturnContact.Text = "";
            ReturnPoints.Text = "";
        }

        // Button click event handler for searching teams by name
     
        private void SearchButton_Click(object sender, EventArgs e)
        {
            
                string searchTerm = SearchTextBox.Text; // Get the search term from the text box

                // Call the SearchEventsByName method from the DataMapper class
                List<TeamDTO> searchResults = dataMapper.SearchTeamsByName(searchTerm);

                // Display the search results in your UI
                // For example, you can populate a DataGridView with the search results
                dataGridView1.DataSource = searchResults;

            
        }

        private void ExportByPoints_Click(object sender, EventArgs e)
        {
            dataMapper.ExportTeamsToCSV(dataMapper.SortTeamsByPoints(), "SortedTeamsByPoints.csv");
        }
    }

      
    }


