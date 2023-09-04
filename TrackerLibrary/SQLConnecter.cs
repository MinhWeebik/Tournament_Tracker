using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SQLConnecter : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the database
        public PrizeModel createPrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
