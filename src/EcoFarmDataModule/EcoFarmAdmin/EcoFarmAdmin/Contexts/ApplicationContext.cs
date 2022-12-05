using EcoFarmAdmin.Domain;
using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin;

public class ApplicationContext : DbContext
{
	public DbSet<DevObject> DevObjects { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite($"Data Source = EcoFarm.db");
}