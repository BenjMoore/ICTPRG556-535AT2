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

namespace ClassLibrary
{
    public partial class Teams : Form
    {
        // Constructor
        public Teams()
        {
            // Initialize form components
            InitializeComponent();
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
            // Retrieve values from WinForms controls
            string teamName = TeamNameTxt.Text.Trim();
            string primaryContact = PrimaryContactTxt.Text.Trim();
            string contactEmail = ContactEmail.Text.Trim();
            string points = PointsTxt.Text.Trim();

            // Check if any of the fields are empty
            if (string.IsNullOrWhiteSpace(teamName) ||
                string.IsNullOrWhiteSpace(primaryContact) ||
                string.IsNullOrWhiteSpace(contactEmail) ||
                string.IsNullOrWhiteSpace(points))
            {
                MessageBox.Show("Please fill in all fields before adding a new team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // Call the AddTeamInfo method in DataMapper to add the new team
            Program.DataMapper.AddTeamInfo(teamName, primaryContact, contactEmail, points);
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
           
            if (string.IsNullOrWhiteSpace(DeleteID.Text))
            {
                MessageBox.Show("Please provide an Event ID to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // Get the event ID, name, location, and date from text boxes
            int IdToDelete;
            if (!int.TryParse(DeleteID.Text, out IdToDelete))
            {
                MessageBox.Show("Invalid Event ID format. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // Call the DeleteTeamInfo method in DataMapper to delete the team
            Program.DataMapper.DeleteTeamInfo(IdToDelete);
            // Clear the DeleteID field after deleting the team
            DeleteID.ResetText();
            // Refresh the TeamInfo DataGridView to reflect the changes
            this.teamInfoTableAdapter.Fill(this.kiddEsportsData.TeamInfo);
        }

        // Button click event handler for sorting teams by points
        private void PointsSortBTN_Click(object sender, EventArgs e)
        {
            // Call the SortTeamsByPoints method in DataMapper to sort teams by points
            List<TeamDTO> sortedTeams = Program.DataMapper.SortTeamsByPoints();
            // Set the DataSource of the DataGridView to display the sorted teams
            dataGridView1.DataSource = sortedTeams;
        }

        // Button click event handler for sorting teams alphabetically
        private void AlphabeticalSortBTN_Click(object sender, EventArgs e)
        {
            // Call the SortTeamsAlphabetically method in DataMapper to sort teams alphabetically
            List<TeamDTO> sortedTeams = Program.DataMapper.SortTeamsAlphabetically();
            // Set the DataSource of the DataGridView to display the sorted teams
            dataGridView1.DataSource = sortedTeams;
        }

        // Button click event handler for updating team information
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            // Retrieve the ID of the team to update
            

            if (string.IsNullOrWhiteSpace(ReturnID.Text))
            {
                MessageBox.Show("Please provide an Event ID to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // Get the event ID, name, location, and date from text boxes
            int IdToUpdate;
            if (!int.TryParse(ReturnID.Text, out IdToUpdate))
            {
                MessageBox.Show("Invalid Event ID format. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }
            // Check if any of the fields are empty
            string Name = ReturnName.Text.Trim();
            string Contact = ReturnContact.Text.Trim();
            string Email = ReturnEmail.Text.Trim();
            string Points = ReturnPoints.Text.Trim();
           

            if (string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Contact) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Points))
            {
                MessageBox.Show("Please fill in all fields before adding a new team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }
            // Create a new TeamDTO object with updated values
            TeamDTO updatedTeamData = new TeamDTO
            {
                ID = IdToUpdate,
                TeamName = ReturnName.Text,
                PrimaryContact = ReturnContact.Text,
                ContactEmail = ReturnEmail.Text,
                Points = Convert.ToInt32(ReturnPoints.Text)
            };
            // Call the SaveUpdatedTeamInfo method in DataMapper to update the team information
            Program.DataMapper.SaveUpdatedTeamInfo(updatedTeamData);
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
            List<TeamDTO> searchResults = Program.DataMapper.SearchTeamsByName(searchTerm);

            // Display the search results in your UI
            // For example, you can populate a DataGridView with the search results
            dataGridView1.DataSource = searchResults;


        }

        private void ExportByPoints_Click(object sender, EventArgs e)
        {
            Program.DataMapper.ExportTeamsToCSV(Program.DataMapper.SortTeamsByPoints(), "SortedTeamsByPoints.csv");
            MessageBox.Show("Export Completed to desktop", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}


