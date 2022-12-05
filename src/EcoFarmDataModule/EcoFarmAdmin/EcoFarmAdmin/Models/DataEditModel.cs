using System;
using System.Windows;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataEditModel
{
	public static void AddProduct()
	{
		if (WindowsTransfer.CreateProduct(out var product))
		{
			DataBaseConnection.CurrentContext.Products.Add(product);
		}
	}

	public static void EditProduct(ref Product product)
	{
		if (WindowsTransfer.EditProduct(product, out var changed))
		{
			product.SetFrom(changed);
		}
	}

	public static void DeleteProduct(Product product)
	{
		try
		{
			DataBaseConnection.CurrentContext.Products.Remove(product);
		}
		catch (Exception e)
		{
			MessageBox.Show(e.Message);
		}
	}
}