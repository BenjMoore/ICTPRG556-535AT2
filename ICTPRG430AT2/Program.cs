
using ClassLibrary;
using ClassLibrary.KiddEsportsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICTPRG430AT2
{
    internal static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            KiddEsportsDataSet KiddEsportsData = new KiddEsportsDataSet();

            TeamInfoTableAdapter teamInfoTableAdapter = new TeamInfoTableAdapter();
            EventsTableAdapter eventTableAdapter = new EventsTableAdapter();
            GamePlayedTableAdapter gameTableAdapter = new GamePlayedTableAdapter();
            TeamResultsTableAdapter teamResultsTableAdapter = new TeamResultsTableAdapter();

            string connectionString = Properties.Settings.Default.ConnectionString;

            DataMapper dataMapper = new DataMapper(connectionString);
          

                try
                {
                    // Specify the file name containing the connection string
                    string fileName = "connectionstring.txt";

                    // Check if the file exists
                    if (File.Exists(fileName))
                    {
                        // Read the connection string from the file
                        string ConnectionString = File.ReadAllText(fileName);

                        // Change the ConnectionString property
                        Properties.Settings.Default.ConnectionString = ConnectionString;
                        Properties.Settings.Default.Save();

                        Console.WriteLine("Connection string updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("The file containing the connection string does not exist.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            
        


        // Retrieve team information

        /*
        int Teams = (int)teamInfoTableAdapter.GetTotalTeamRows();
        int Event = (int)eventTableAdapter.GetEventRows();
        int Result = (int)teamResultsTableAdapter.GetResultsRows();
        int Game = (int)gameTableAdapter.GetGameRows();


        // Check if the team data table is empty
        if ( Teams == 0)
        {

            // Add filler data if the table is empty
            dataMapper.AddTeamInfo("TeamA", "John Doe", "john.doe@example.com", "100");
            dataMapper.AddTeamInfo("TeamB", "Jane Smith", "jane.smith@example.com", "150");
            dataMapper.AddTeamInfo("TeamC", "Mike Johnson", "mike.johnson@example.com", "120");


        }
        if (Event == 0)
        {
            dataMapper.AddEventInfo("TestEvent", "Brisbane", "12-02-24");
            dataMapper.AddEventInfo("TestEvent2", "Brisbane", "13-02-24");
            dataMapper.AddEventInfo("TestEvent3", "Brisbane", "14-02-24");

        }
        if (Game == 0)
        {
            dataMapper.AddGameInfo("FakeGame", "Solos");
            dataMapper.AddGameInfo("FakeGame2", "Duos");
            dataMapper.AddGameInfo("FakeGame3", "Squads");
        }
        if (Result == 0)
        {
            dataMapper.AddResultInfo("TestEvent", "FakeGame", "TeamA", "TeamB", "Win");
            dataMapper.AddResultInfo("TestEvent2", "FakeGame2", "TeamB", "TeamC", "Loss");
            dataMapper.AddResultInfo("TestEvent3", "FakeGame3", "TeamA", "TeamC", "Draw");
        }
       */
        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());


        }


    }
}
