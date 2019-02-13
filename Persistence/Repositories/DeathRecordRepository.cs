using RoyCityCemetery.Core.Domain;
using RoyCityCemetery.Core.Repositories;

namespace RoyCityCemetery.Persistence.Repositories
{
    public class DeathRecordRepository : Repository<DeathRecord>, IDeathRecordRepository
    {
        public DeathRecordRepository(CemeteryContext context)
            : base(context)
        {
        }
    }
}