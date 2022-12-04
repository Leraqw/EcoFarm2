using System;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataEditModel
{
	public static void EditProduct(DevObject devObject)
	{
		if (WindowsTransfer.EditProduct(ref devObject))
		{
			SaveChanges(devObject);
		}
	}

	private static void SaveChanges(DevObject newDevObject)
	{
		var devObject = DataBaseConnection.CurrentContext?.DevObjects.Find(newDevObject.Id)
		                ?? throw new NullReferenceException();

		devObject.SetFrom(newDevObject);
		DataBaseConnection.CurrentContext.SaveChanges();
	}
}