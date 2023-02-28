using Microsoft.EntityFrameworkCore;

namespace Atm.DAL.Database
{
    internal class AtmDbContext : DbContext
    {
        public AtmDbContext(DbContextOptions<AtmDbContext> options) : base(options)
        {

        }
    }
}
