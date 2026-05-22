using Microsoft.EntityFrameworkCore;
using Tutorial_5.Entity;

namespace Tutorial_5.Data;

public class AppDbContext : DbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}

public DbSet<Component> Components => Set<Component>();
public DbSet<ComponentManufactures> ComponentManufacturers => Set<ComponentManufactures>();
public DbSet<ComponentType> ComponentTypes => Set<ComponentType>();
public DbSet<PC> PCs => Set<PC>();
public DbSet<PCComponents> PCComponents => Set<PCComponents>();

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Component>()
        .HasOne<ComponentManufactures>()
        .WithMany(m => m.Components)
        .HasForeignKey(c => c.ComponentManufacturersId);

    modelBuilder.Entity<Component>()
        .HasOne<ComponentType>()
        .WithMany(t => t.Components)
        .HasForeignKey(c => c.ComponentTypesId);

    modelBuilder.Entity<PCComponents>()
        .HasOne(pc => pc.Pc)
        .WithMany(p => p.PCsComponents)
        .HasForeignKey(pc => pc.PCId);

    modelBuilder.Entity<PCComponents>()
        .HasOne(pc => pc.Component)
        .WithMany(c => c.PCsComponents)
        .HasForeignKey(pc => pc.ComponentCode);
    }
}