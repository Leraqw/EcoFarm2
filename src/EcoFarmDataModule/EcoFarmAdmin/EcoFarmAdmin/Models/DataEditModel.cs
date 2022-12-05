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

	public static void EditProduct(ref DevObject devObject)
	{
		if (WindowsTransfer.EditProduct(devObject, out var changed))
		{
			devObject.SetFrom(changed);
			devObject.OnPropertyChanged();
			SaveChanges(changed);
		}
	}

	private static void SaveChanges(DevObject newDevObject)
	{
		var devObject = DataBaseConnection.CurrentContext.DevObjects.Find(newDevObject.Id)
		                ?? throw new NullReferenceException("devObject not founded in database");

		devObject.SetFrom(newDevObject);
		DataBaseConnection.CurrentContext.SaveChanges();
	}
}