using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin;

public class ApplicationContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite("Data Source = test.db");
}