using RoyCityCemetery.Core;
using RoyCityCemetery.Core.Repositories;
using RoyCityCemetery.Persistence;
using RoyCityCemetery.Persistence.Repositories;

namespace Queries.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CemeteryContext _context;

        public UnitOfWork(CemeteryContext context)
        {
            _context = context;
            DeathRecords = new DeathRecordRepository(_context);
        }

        public IDeathRecordRepository DeathRecords { get; private set; }

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