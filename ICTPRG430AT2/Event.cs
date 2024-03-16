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
    /// <summary>
    /// Represents the main form for managing events.
    /// </summary>
    public partial class Event : Form
    {      
        // Constructor for the Event form
        public Event()
        {
            InitializeComponent();
        }

        // Event handler for the form load event
        /// <summary>
        /// Handles the form's Load event.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void Events_Load(object sender, EventArgs e)
        {
            // Load data into the event table from the database
            this.eventTableAdapter.Fill(this.kiddEsportsData_View.Event);
        }

        // Method to retrieve a new event ID from the database
        /// <summary>
        /// Retrieves a new event ID from the database.
        /// </summary>
        /// <returns>The new event ID.</returns>
        private int GetNewEventID()
        {
            int newID = 0;

            string query = "SELECT MAX(ID) FROM Event";

            using (SqlConnection connection = new SqlConnection(Program.DataMapper.DboConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        newID = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        newID = 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return newID;
        }

      
        private void AddEventBTN_Click(object sender, EventArgs e)
        {
            // Get new event ID, event name, location, and date from text boxes
            int id = GetNewEventID();
            string teamName = EventNameTXT.Text;
            string primaryContact = EventLocationTXT.Text;
            string contactEmail = EventDateTXT.Text;

            // Call the AddEventInfo method in DataMapper to add the new event information
            Program.DataMapper.AddEventInfo(teamName, primaryContact, contactEmail);
            // Refresh the data in the event table
            this.eventTableAdapter.Fill(this.kiddEsportsData_View.Event);

            // Clear the text boxes after adding the event
            EventNameTXT.ResetText();
            EventLocationTXT.ResetText();
            EventDateTXT.ResetText();
        }

      
        private void DeteleBTN_Click(object sender, EventArgs e)
        {
            // Get the event ID to delete from the text box
            int id = Convert.ToInt32(DeleteID.Text);

            // Call the DeleteEventInfo method in DataMapper to delete the event information
            Program.DataMapper.DeleteEventInfo(id);
            // Refresh the data in the event table
            this.eventTableAdapter.Fill(this.kiddEsportsData_View.Event);

            // Clear the text box after deleting the event
            DeleteID.ResetText();
        }

        private void UpdateBTN_Click_1(object sender, EventArgs e)
        {
            // Get the event ID, name, location, and date from text boxes
            int eventIdToUpdate = Convert.ToInt32(ReturnID.Text);
            EventDTO updatedEventData = new EventDTO
            {
                ID = eventIdToUpdate,
                EventName = ReturnName.Text,
                EventLocation = ReturnLocation.Text,
                EventDate = ReturnDate.Text
            };

            // Call the SaveUpdatedEventInfo method in DataMapper to update the event information
            Program.DataMapper.SaveUpdatedEventInfo(updatedEventData);
            // Refresh the data in the event table
            ReturnName.ResetText();
            ReturnLocation.ResetText();
            ReturnDate.ResetText();
            ReturnID.ResetText();
            this.eventTableAdapter.Fill(this.kiddEsportsData_View.Event);
        }
        // Event handler for the "Search" button click event


        // Event handler for the "New Event" button click event

        private void Event_Load(object sender, EventArgs e)
        {
      
            this.eventTableAdapter.Fill(this.kiddEsportsData_View.Event);

        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            // Get the search term from the text box
            string searchTerm = SearchTextBox.Text;

            // Call the SearchEventsByName method in DataMapper to search for events by name
            List<EventDTO> searchResults = Program.DataMapper.SearchEventsByName(searchTerm);

            // Display the search results in the DataGridView
            dataGridView1.DataSource = searchResults;
        }

        private void HomeBTN_Click(object sender, EventArgs e) // Home BTN
        {
            this.Hide();
            var form2 = new Menu();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void EventBTN_Click(object sender, EventArgs e) // Event BTN
        {

            this.Hide();
            var form2 = new Event();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void ResultsBTN_Click(object sender, EventArgs e) // Results BTN
        {

            this.Hide();
            var form2 = new Results();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void NewGameBTN_Click(object sender, EventArgs e) // NewGame BTN
        {

            this.Hide();
            var form2 = new NewGame();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void TeamsBTN_Click(object sender, EventArgs e) // Team BTN
        {

            this.Hide();
            var form2 = new Teams();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

       
    }
}
