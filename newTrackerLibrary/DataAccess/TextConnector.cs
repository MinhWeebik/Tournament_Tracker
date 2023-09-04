using newTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the createPrize for the text files
        public PrizeModel createPrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
