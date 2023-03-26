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
    public class PortRepository : Repository<Port>, IPortRepository
    {
        public PortRepository(TSDBContext tsdbContext) : base(tsdbContext)
        {
        }

        public IEnumerable<Port> GetPortsByLatitude(int latitude)
        {
            return TSDBContext.Ports.Where(a => a.Latitude == latitude).ToList();
        }

        public IEnumerable<Port> GetPortsByLongitude(int longitude)
        {
            return TSDBContext.Ports.Where(a => a.Longitude == longitude).ToList();
        }

        public TSDBContext TSDBContext { get { return Context as TSDBContext; } }
    }
}
