using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Core.Persistence;

namespace TS.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IShipRepository ShipRepository { get; }
        IPortRepository PortRepository { get; }
        int Complete();
    }
}
