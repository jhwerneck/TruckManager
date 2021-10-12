using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TruckManager.Domain.Entities;
using System.Linq;

namespace TruckManager.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Truck> Trucks { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreationDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreationDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreationDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
