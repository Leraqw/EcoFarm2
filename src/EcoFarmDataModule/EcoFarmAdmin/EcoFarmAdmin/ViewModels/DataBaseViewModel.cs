using System;
using System.Collections.Generic;
using System.Windows;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataBaseViewModel : ViewModelBase
{
	public IEnumerable<DevObject> DevObjects
		=> DataBaseConnection.CurrentContext?.DevObjects.Local.ToObservableCollection()
		   ?? throw new NullReferenceException();

	public ICommand<DevObject> EditDevObject => new DelegateCommand<DevObject>(DataEditModel.EditProduct);
}

public class DataEditModel
{
	public static void EditProduct(DevObject devObject)
	{
		if (WindowsTransfer.EditProduct(ref devObject))
		{
			MessageBox.Show("Saved");
			DataBaseConnection.CurrentContext.SaveChanges();
		}
	}
}