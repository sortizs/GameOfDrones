using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;

namespace gameApi.Models
{
    public partial class GameDronesContext : DbContext
    {
        public GameDronesContext() { }
        public GameDronesContext(DbContextOptions<GameDronesContext> options)
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Winner> Winner { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Winner>(entity =>
            {
                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Winner)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Winner__Username__4BAC3F29");
            });
        }
    }
}
