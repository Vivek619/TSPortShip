using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Models.Models;

namespace TS.Core.Persistence
{
    public interface IShipRepository : IRepository<Ship>
    {
        IEnumerable<Ship> GetShipsByLatitude(int latitude);
        IEnumerable<Ship> GetShipsByLongitude(int longitude);
    }
}
