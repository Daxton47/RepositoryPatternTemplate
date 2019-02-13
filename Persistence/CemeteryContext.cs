using RoyCityCemetery.Core.Domain;
using System.Data.Entity;

namespace RoyCityCemetery.Persistence
{
    public class CemeteryContext : DbContext
    {
        public CemeteryContext()
            : base("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<DeathRecord> DeathRecords { get; set; }
        public virtual DbSet<DeathRecord_Link> DeathRecord_Links { get; set; }
        public virtual DbSet<DeathRecord_Note> DeathRecord_Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Add custom configurations here
        }
    }
}
