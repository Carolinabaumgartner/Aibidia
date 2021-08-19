using First.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.Storage
{
    public class AibidiaDatabaseContext : DbContext
    {
        public DbSet<Continent> Continents { get; set; }

        public string DbPath { get; private set; }

        public AibidiaDatabaseContext()
        {
            DbPath = @"C:\Users\carol\OneDrive\Desktop\Aibidia_Tables.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
