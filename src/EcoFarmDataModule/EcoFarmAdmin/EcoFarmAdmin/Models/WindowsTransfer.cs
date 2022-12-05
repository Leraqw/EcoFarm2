using EcoFarmAdmin.Domain;
using EcoFarmAdmin.EditWindows;

namespace EcoFarmAdmin.ViewModels;

public static class WindowsTransfer
{
	public static void ToProductsListWindow() => new ProductsListWindow().Show();

	public static void ToTreesListWindow() => new TreesListWindow().Show();

	public static bool CreateProduct(out Product devObject) => EditProduct(new Product(), out devObject);

	public static bool EditProduct(in Product devObject, out Product changed)
	{
		var window = new ProductEditWindow();
		var context = (ProductEditViewModel)window.DataContext;

		context.Product = devObject.Clone();
		window.ShowDialog();

		changed = context.Product;
		return window.DialogResult ?? false;
	}
}