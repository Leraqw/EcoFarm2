using System;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataEditModel
{
	public static void AddProduct()
	{
		if (WindowsTransfer.CreateProduct(out var product))
		{
			DataBaseConnection.CurrentContext.DevObjects.Add(product);
		}
	}

	public static void EditProduct(ref Product product)
	{
		if (WindowsTransfer.EditProduct(product, out var changed))
		{
			SaveChanges(product.SetFrom(changed));
		}
	}

	private static void SaveChanges(Product product)
	{
		var devObject = DataBaseConnection.CurrentContext.DevObjects.Find(product.Id)
		                ?? throw new NullReferenceException("product not founded in database");

		devObject.SetFrom(product);
		DataBaseConnection.CurrentContext.SaveChanges();
	}
}