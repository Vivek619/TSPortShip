using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Models.Models;

namespace TS.Core.Persistence
{
    public interface IPortRepository : IRepository<Port>
    {
        IEnumerable<Port> GetPortsByLatitude(int latitude);
        IEnumerable<Port> GetPortsByLongitude(int longitude);
    }
}
