using System;
using System.Windows;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataEditModel
{
	public static void EditProduct(ref DevObject devObject)
	{
		if (WindowsTransfer.EditProduct(devObject, out var changed))
		{
			devObject.SetFrom(changed);
			SaveChanges(changed);
		}
	}

	private static void SaveChanges(DevObject newDevObject)
	{
		var context = DataBaseConnection.CurrentContext ?? throw new NullReferenceException();
		var devObject = context.DevObjects.Find(newDevObject.Id)
		                ?? throw new NullReferenceException("devObject not founded in database");

		devObject.SetFrom(newDevObject);
		context.SaveChanges();
	}
}