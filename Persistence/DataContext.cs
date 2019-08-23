using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(new Value() { Id = 1, Name = "Test 1" }, new Value() { Id = 2, Name = "Test 2" });
        }

        public DbSet<Value> Values { get; set; }
    }
}
