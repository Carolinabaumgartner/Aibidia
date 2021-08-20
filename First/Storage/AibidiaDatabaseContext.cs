using First.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace First.Storage
{
    public class AibidiaDatabaseContext : DbContext
    {
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Ruling> Rulings { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Legislation> Legislations { get; set; }

        public string DbPath { get; private set; }

        public AibidiaDatabaseContext()
        {
            DbPath = @$"{AppDomain.CurrentDomain.BaseDirectory}Database\Aibidia_Tables.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agreement>().HasKey(a => new { a.Company1ID, a.Company2ID });
        }
    }
}
