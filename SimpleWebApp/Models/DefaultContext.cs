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

        //public DbSet<UserData> Users { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Person> Persons { get; set; }
        //public DbSet<MinistryAction> MinistryActions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Encounter>()
                .HasOne(e => e.Person)
                .WithOne(p => p.Encounter)
                .HasForeignKey<Person>(p => p.EncounterId);
        }
        
        //public DbSet<MinistryAction> MinistryActions { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserData>().ToTable("Users");
        //    modelBuilder.Entity<Encounter>().ToTable("Encounters");
        //}
    }
}