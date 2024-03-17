
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
namespace ClassLibrary
{
}
namespace ClassLibrary
{
    internal static class Program
    {
        public static DataMapper DataMapper;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TeamInfoTableAdapter teamInfoTableAdapter = new TeamInfoTableAdapter();
            EventsTableAdapter eventTableAdapter = new EventsTableAdapter();
            GamePlayedTableAdapter gameTableAdapter = new GamePlayedTableAdapter();

            DataMapper = new DataMapper();

            #region Get Counts
            int teamsCount = (int)teamInfoTableAdapter.GetTotalTeamRows();
            int eventCount = (int)eventTableAdapter.GetEventRows();
            int gameCount = (int)gameTableAdapter.GetGameRows();
            #endregion

            CreateTestDataIfEmptyDB(teamsCount, eventCount, gameCount);

            #region Setup Application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
            #endregion
        }

        private static void CreateTestDataIfEmptyDB(int teamsCount, int eventCount, int gameCount)
        {
            // Add filler data if the table is empty
            if (teamsCount == 0)
            {
                DataMapper.AddTeamInfo("TeamA", "John Doe", "john.doe@example.com", "100");
                DataMapper.AddTeamInfo("TeamB", "Jane Smith", "jane.smith@example.com", "150");
                DataMapper.AddTeamInfo("TeamC", "Mike Johnson", "mike.johnson@example.com", "120");


            }
            if (eventCount == 0)
            {
                DataMapper.AddEventInfo("TestEvent", "Brisbane", "12-02-24");
                DataMapper.AddEventInfo("TestEvent2", "Brisbane", "13-02-24");
                DataMapper.AddEventInfo("TestEvent3", "Brisbane", "14-02-24");

            }
            if (gameCount == 0)
            {
                DataMapper.AddGameInfo("FakeGame", "Solos");
                DataMapper.AddGameInfo("FakeGame2", "Duos");
                DataMapper.AddGameInfo("FakeGame3", "Squads");
            }
        }
    }
}
