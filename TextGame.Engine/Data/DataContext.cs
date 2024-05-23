using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TextGame.Engine.Entities;

namespace TextGame.Engine.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Scene> Scenes => Set<Scene>();
        public DbSet<Image> Images => Set<Image>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=gameapp.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
