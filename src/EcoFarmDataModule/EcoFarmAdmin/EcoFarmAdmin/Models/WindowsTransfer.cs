using EcoFarmAdmin.Domain;
using EcoFarmAdmin.EditWindows;

namespace EcoFarmAdmin.ViewModels;

public static class WindowsTransfer
{
	public static void ToProductsListWindow() => new ProductsListWindow().Show();

	public static bool CreateProduct(out DevObject devObject) => EditProduct(new DevObject(), out devObject);

	public static bool EditProduct(in DevObject devObject, out DevObject changed)
	{
		var window = new ProductEditWindow();
		var context = (ProductEditViewModel)window.DataContext;

		context.DevObject = devObject.Clone();
		window.ShowDialog();

		changed = context.DevObject;
		return window.DialogResult ?? false;
	}
}