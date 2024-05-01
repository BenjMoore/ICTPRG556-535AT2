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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClassLibrary
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
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // Event handler for the form load event
        /// <summary>
        /// Handles the form's Load event.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void Events_Load(object sender, EventArgs e)
        {

            // Load data into the Events DataGridView
            //this.EventTableAdapter.Fill(this.kiddEsportsData.Events);

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
            
            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            DateTime selectedDateTime = DateTimePicker.Value;
           
            // Get new event ID, event name, location, and date from text boxes
            int id = GetNewEventID();
            string teamName = EventNameTXT.Text;
            string primaryContact = EventLocationTXT.Text;
            string contactEmail = selectedDateTime.ToString("MM/dd/yyyy hh:mm tt");

            if (string.IsNullOrWhiteSpace(teamName) ||
            string.IsNullOrWhiteSpace(primaryContact) ||
                string.IsNullOrWhiteSpace(contactEmail) )
            {
                MessageBox.Show("Please fill in all fields before adding a new team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }
            // Call the AddEventInfo method in DataMapper to add the new event information
            Program.DataMapper.AddEventInfo(teamName, primaryContact, contactEmail);
            // Refresh the data in the event table
           // this.eventTableAdapter.Fill(this.kiddEsportsData.Events);

            // Clear the text boxes after adding the event
            EventNameTXT.ResetText();
            EventLocationTXT.ResetText();
            
        }


        private void DeteleBTN_Click(object sender, EventArgs e)
        {
            // Get the event ID to delete from the text box
           
            if (string.IsNullOrWhiteSpace(DeleteID.Text))
            {
                MessageBox.Show("Please provide an Event ID to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // Get the event ID, name, location, and date from text boxes
            int eventIdToUpdate;
            if (!int.TryParse(DeleteID.Text, out eventIdToUpdate))
            {
                MessageBox.Show("Invalid Event ID format. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // Call the DeleteEventInfo method in DataMapper to delete the event information

            Program.DataMapper.DeleteEventInfo(eventIdToUpdate);

            // Refresh the data in the event table
            //this.eventTableAdapter.Fill(this.kiddEsportsData_View.Event);

            // Clear the text box after deleting the event
            DeleteID.ResetText();
        }

        private void UpdateBTN_Click_1(object sender, EventArgs e)
        {
            // Get the event ID, name, location, and date from text boxes
           
             if (string.IsNullOrWhiteSpace(ReturnID.Text))
            {
                MessageBox.Show("Please provide an Event ID to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // Get the event ID, name, location, and date from text boxes
            int eventIdToUpdate;
            if (!int.TryParse(ReturnID.Text, out eventIdToUpdate))
            {
                MessageBox.Show("Invalid Event ID format. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }
            string Name = ReturnName.Text.Trim();
            string Location = ReturnLocation.Text.Trim();
            string Date = ReturnDate.Text.Trim();
           

            if (string.IsNullOrWhiteSpace(Name) ||
            string.IsNullOrWhiteSpace(Location) ||
                string.IsNullOrWhiteSpace(Date))
            {
                MessageBox.Show("Please fill in all fields before adding a new team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

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
            //this.eventTableAdapter.Fill(this.kiddEsportsData_View.Event);
        }
        // Event handler for the "Search" button click event


        // Event handler for the "New Event" button click event

        private void Event_Load(object sender, EventArgs e)
        {

           // this.eventTableAdapter.Fill(this.kiddEsportsData_View.Event);

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the update section with data from the selected row
                ReturnID.Text = row.Cells["IDColumn"].Value.ToString();
                ReturnName.Text = row.Cells["EventNameColumn"].Value.ToString();
                ReturnLocation.Text = row.Cells["EventLocationColumn"].Value.ToString();
                ReturnDate.Text = row.Cells["EventDateColumn"].Value.ToString();
               
            }
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
