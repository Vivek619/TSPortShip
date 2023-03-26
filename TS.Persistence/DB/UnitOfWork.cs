using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Core.Persistence;
using TS.Core.UnitOfWork;
using TS.Persistence.Repository;

namespace TS.Persistence.DB
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TSDBContext _context;

        public UnitOfWork(TSDBContext context)
        {
            _context = context;
            ShipRepository = new ShipRepository(_context);
            PortRepository = new PortRepository(_context);
        }

        public IShipRepository ShipRepository { get; private set; }

        public IPortRepository PortRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
