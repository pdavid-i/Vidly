using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Vidly.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Vidly.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DatabaseContext")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}