using EcoFarmAdmin.Domain;
using EcoFarmAdmin.Utils;
using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin;

public class ApplicationContext : DbContext
{
	public DbSet<DevObject>               DevObjects                { get; set; } = null!;
	public DbSet<Product>                 Products                  { get; set; } = null!;
	public DbSet<Tree>                    Trees                     { get; set; } = null!;
	public DbSet<Level>                   Levels                    { get; set; } = null!;
	public DbSet<DevObjectOnLevelStartup> DevObjectsOnLevelsStartup { get; set; } = null!;
	public DbSet<Goal>                    Goals                     { get; set; } = null!;
	public DbSet<Resource>                Resources                 { get; set; } = null!;
	public DbSet<Building>                Buildings                 { get; set; } = null!;
	public DbSet<Generator>               Generators                { get; set; } = null!;
	public DbSet<Factory>                 Factories                 { get; set; } = null!;
	public DbSet<InputProduct>           InputProducts             { get; set; } = null!;
	public DbSet<OutputProduct>          OutputProducts            { get; set; } = null!;

	public ApplicationContext()
	{
		Table<DevObject>.Value = DevObjects;
		Table<Product>.Value = Products;
		Table<Tree>.Value = Trees;
		Table<Level>.Value = Levels;
		Table<DevObjectOnLevelStartup>.Value = DevObjectsOnLevelsStartup;
		Table<Goal>.Value = Goals;
		Table<Resource>.Value = Resources;
		Table<Building>.Value = Buildings;
		Table<Generator>.Value = Generators;
		Table<Factory>.Value = Factories;
		Table<InputProduct>.Value = InputProducts;
		Table<OutputProduct>.Value = OutputProducts;
	}

	public DbSet<T> GetTable<T>()
		where T : class
		=> Table<T>.Value;

	public bool TrySaveChanges()
	{
		try
		{
			DataBaseConnection.CurrentContext.SaveChanges();
			return true;
		}
		catch (DbUpdateException)
		{
			MessageBoxUtils.ShowError
			(
				"Не удалось сохранить изменения в базе данных. "
				+ "Возможно вы заполнили не все поля."
			);
			return false;
		}
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite("Data Source = EcoFarm.db");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
		=> modelBuilder.Entity<DevObject>().UseTptMappingStrategy();

	private static class Table<T>
		where T : class
	{
		public static DbSet<T> Value = null!;
	}
}