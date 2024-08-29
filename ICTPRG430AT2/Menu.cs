using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
namespace ClassLibrary
{
    /// <summary>
    /// Represents the main menu form.
    /// </summary>
    public partial class Menu : Form
    {
        private DataMapper dataMapper;



        // Constructor for the Menu form
        public Menu()
        {
            InitializeComponent();
        }

        // Event handler for the form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill the team information from the database
            this.teamInfoTableAdapter1.Fill(this.kiddEsportsData1.TeamInfo);
        }

        // Event handler for saving changes to the team information
        private void teamInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamInfoBindingSource.EndEdit();
            // Update all changes to the database
            this.tableAdapterManager.UpdateAll(this.kiddEsportsData);
        }



        private void Exit_Click(object sender, EventArgs e) // Exit Button
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)// Teams Button
        {
            this.Hide();
            var form2 = new Teams();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)// Event Button
        {
            this.Hide();
            var form2 = new Event();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)// NewGame Button
        {
            this.Hide();
            var form2 = new NewGame();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }


        private void Results_Click(object sender, EventArgs e)// Results Button
        {
            this.Hide();
            var form2 = new Results();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void Connect_Click(object sender, EventArgs e)
        {

        }

    }
}
