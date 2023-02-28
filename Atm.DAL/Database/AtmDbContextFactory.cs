using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Design;

namespace Atm.DAL.Database
{
    internal class AtmDbContextFactory : IDesignTimeDbContextFactory<AtmDbContext>
    {
        public AtmDbContextFactory()
        {

        }
        public AtmDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AtmDbContext>();
            var connectionString = @"Data Source=DAGRAY\SQLEXPRESS;Integrated Security=True;Initial Catalog=AtmOnEfcore;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connectionString);
            Console.WriteLine(connectionString);
            return new AtmDbContext(optionsBuilder.Options);
        }
    }
}
