using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Core.Persistence;
using TS.Models.Models;
using TS.Persistence.DB;

namespace TS.Persistence.Repository
{
    public class ShipRepository : Repository<Ship>, IShipRepository
    {
        public ShipRepository(TSDBContext tsdbContext): base(tsdbContext)
        {
        }

        public IEnumerable<Ship> GetShipsByLatitude(int latitude)
        {
            return TSDBContext.Ships.Where(a => a.Latitude == latitude).ToList();
        }

        public IEnumerable<Ship> GetShipsByLongitude(int longitude)
        {
            return TSDBContext.Ships.Where(a => a.Longitude == longitude).ToList();
        }

        public TSDBContext TSDBContext { get {  return Context as TSDBContext; } }
    }
}
