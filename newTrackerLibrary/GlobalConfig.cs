using newTrackerLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        //Khởi tạo kết nối
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //TODO - set up the SQL Connection properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //TODO - create the Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
