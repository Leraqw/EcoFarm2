using System;
using System.Windows;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataEditModel
{
	public static void AddProduct() => DataBaseConnection.CurrentContext.Products.Add(new Product());

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