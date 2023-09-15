﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Khởi tạo kết nối database
            newTrackerLibrary.GlobalConfig.InitializeConnections(newTrackerLibrary.DatabaseType.Sql);
            Application.Run(new TournamentDashBoardForm());

            //Application.Run(new TournamentDashboardForm());
        }
    }
}
