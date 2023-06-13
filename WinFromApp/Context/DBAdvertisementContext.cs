using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WinFromApp.Context
{
    public partial class DBAdvertisementContext : DbContext
    {
        public DBAdvertisementContext()
            : base("name=DBAdvertisementContext")
        {
        }

        public virtual DbSet<Advertisements> Advertisements { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisements>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);
        }
    }
}
