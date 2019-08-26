using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        //Use below command for adding migration
        //dotnet ef migrations add "ActivityEntityAdded" -p Persistence/ -s API/
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(new Value() { Id = 1, Name = "Test 1" }, new Value() { Id = 2, Name = "Test 2" });
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
