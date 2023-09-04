using newTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel createPrize(PrizeModel model);

    }
}
