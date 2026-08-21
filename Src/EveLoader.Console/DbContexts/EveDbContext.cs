
using EveLoader.Entities;
using Microsoft.EntityFrameworkCore;


namespace EveLoader.DbContexts
{
    public class EveDbContext : DbContext
    {
        public EveDbContext(DbContextOptions<EveDbContext> options)
         : base(options)
        {
        }


        public DbSet<SkinrComponentCategories> SkinrComponentCategories { get; set; }
        public DbSet<SkinrSlotCategories> SkinrSlotCategories { get; set; }

    }
}
