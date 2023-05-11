using Microsoft.EntityFrameworkCore;
using SdominoData.Models.Entities;

namespace SdominoData.Repositories;

public partial class SdominoContext : DbContext
{
    public SdominoContext()
    {
    }

    public SdominoContext(DbContextOptions<SdominoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Receipt> Receipts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order__3214EC07BA746A88");

            entity.ToTable("Order");

            entity.Property(e => e.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<Receipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Receipt__3214EC079EFECC95");

            entity.ToTable("Receipt");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.Order).WithMany(p => p.Receipts)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Receipt__OrderId__403A8C7D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
