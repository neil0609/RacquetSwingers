using Microsoft.EntityFrameworkCore;
using RacquetSwingers.Models.Domain;


namespace RacquetSwingers.Entities
{
    public class RacquetSwingersDbContext : DbContext
    {
        public RacquetSwingersDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<RacquetSwingersDomain> RacquetSwinger { get; set; }
    }
}
