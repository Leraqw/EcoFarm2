using EcoFarmAdmin.Domain;
using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin;

public class ApplicationContext : DbContext
{
	private readonly string _path;

	public ApplicationContext(string path) => _path = path;

	public DbSet<DevObject> DevObjects { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite($"Data Source = {_path}");
}