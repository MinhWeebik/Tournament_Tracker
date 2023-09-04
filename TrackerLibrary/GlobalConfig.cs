using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
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
                SQLConnecter sql = new SQLConnecter();
                Connections.Add(sql);
            }
            if(textFiles)
            {
                //TODO - create the Text Connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }

    }
}
