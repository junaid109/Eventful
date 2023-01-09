using Eventful.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventful.Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<EventEntity> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventEntity>().HasKey(x => x.Id);
            modelBuilder.Entity<EventEntity>().Property(x => x.Id).IsRequired();
            modelBuilder.Entity<EventEntity>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<EventEntity>().Property(x => x.Description).IsRequired();
            modelBuilder.Entity<EventEntity>().Property(x => x.Location).IsRequired();
            modelBuilder.Entity<EventEntity>().Property(x => x.StartDate).IsRequired();
            modelBuilder.Entity<EventEntity>().Property(x => x.EndDate).IsRequired();
            modelBuilder.Entity<EventEntity>().Property(x => x.ImageUrl).IsRequired();
            modelBuilder.Entity<EventEntity>().Property(x => x.Url).IsRequired();
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EventfulDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

  


    }
}
