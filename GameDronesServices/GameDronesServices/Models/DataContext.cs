namespace GameDronesServices.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Winner> Winner { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Winner)
                .WithRequired(e => e.Player)
                .HasForeignKey(e => e.Username)
                .WillCascadeOnDelete(false);
        }
    }
}
