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
			DataBaseConnection.CurrentContext.SaveChanges();
		}
	}

	public static void EditProduct(ref Product product)
	{
		if (WindowsTransfer.EditProduct(product, out var changed))
		{
			SaveChanges(product.SetFrom(changed));
		}
	}

	public static void SaveChanges(Product newProduct)
	{
		var product = DataBaseConnection.CurrentContext.Products.Find(newProduct.Id)
		              ?? throw new NullReferenceException("product not founded in database");

		product.SetFrom(newProduct);
		DataBaseConnection.CurrentContext.SaveChanges();
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

		DataBaseConnection.CurrentContext.SaveChanges();
	}
}