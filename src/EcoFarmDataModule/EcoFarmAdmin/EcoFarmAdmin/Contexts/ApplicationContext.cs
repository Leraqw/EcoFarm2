using EcoFarmAdmin.Domain;
using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin;

public class ApplicationContext : DbContext
{
	public DbSet<DevObject> DevObjects { get; set; } = null!;
	public DbSet<Product>   Products   { get; set; } = null!;
	public DbSet<Tree>      Trees      { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite("Data Source = EcoFarm.db");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
		=> modelBuilder.Entity<DevObject>().UseTptMappingStrategy();
}