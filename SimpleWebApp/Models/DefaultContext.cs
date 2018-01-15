using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Models;

namespace SimpleWebApp.Context
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        public DbSet<UserData> Users { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Person> Person { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserData>().ToTable("Users");
        //    modelBuilder.Entity<Encounter>().ToTable("Encounters");
        //}
    }
}