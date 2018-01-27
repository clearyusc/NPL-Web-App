using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Models;
using SimpleWebApp.Services;

namespace SimpleWebApp.Context
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserData> Users { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<MinistryAction> MinistryActions { get; set; }


        //public DbSet<MinistryAction> MinistryActions { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserData>().ToTable("Users");
        //    modelBuilder.Entity<Encounter>().ToTable("Encounters");
        //}
    }
}