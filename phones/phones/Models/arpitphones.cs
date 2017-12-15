namespace phones.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class arpitphones : DbContext
    {
        public arpitphones()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<C2arpitphones> C2arpitphones { get; set; }
        public virtual DbSet<arpitphone> arpitphone { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C2arpitphones>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<C2arpitphones>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<arpitphone>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<arpitphone>()
                .Property(e => e.models)
                .IsUnicode(false);
        }
    }
}
