#nullable disable
using Microsoft.EntityFrameworkCore;
using GrowthPlan.Domain.Entities;

namespace GrowthPlan.Infrastructure;

public partial class GrowthPlanDatabaseContext : DbContext
{
    public GrowthPlanDatabaseContext(DbContextOptions<GrowthPlanDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Plant> Plants { get; set; }

    public virtual DbSet<Planting> Plantings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Plant>(entity =>
        {
            entity.ToTable("Plant");

            entity.Property(e => e.PlantId).ValueGeneratedNever();
            entity.Property(e => e.CommonName).HasMaxLength(200);
            entity.Property(e => e.ScientificName).HasMaxLength(200);
        });

        modelBuilder.Entity<Planting>(entity =>
        {
            entity.ToTable("Planting");

            entity.Property(e => e.PlantingId).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.SeedPlanted).HasColumnType("date");

            entity.HasOne(d => d.Plant).WithMany(p => p.Plantings)
                .HasForeignKey(d => d.PlantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Plant_Planting");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}