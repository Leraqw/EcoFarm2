namespace EcoFarmAdmin.ViewModels;

public static class WindowsTransfer
{
	public static void ToProductsListWindow() => new ProductsListWindow().Show();

	public static void ToTreesListWindow() => new TreesListWindow().Show();

	public static void ToLevelsListWindow() => new LevelsListWindow().Show();

	public static void ToResourcesListWindow() => new ResourcesWindow().Show();

	public static void ToGeneratorsListWindow() => new GeneratorsWindow().Show();

	public static void ToFactoriesListWindow() => throw new System.NotImplementedException();
}