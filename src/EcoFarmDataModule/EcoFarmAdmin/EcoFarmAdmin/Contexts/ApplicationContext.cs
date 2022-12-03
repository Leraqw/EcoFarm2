using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin;

public class ApplicationContext : DbContext
{
	private readonly string _path;

	public ApplicationContext(string path) => _path = path;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite($"Data Source = {_path}.db");
}