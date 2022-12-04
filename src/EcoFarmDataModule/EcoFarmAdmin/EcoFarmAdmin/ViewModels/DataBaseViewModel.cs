using System;
using System.Collections.Generic;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataBaseViewModel : ViewModelBase
{
	public IEnumerable<DevObject> DevObjects
		=> DataBaseConnection.CurrentContext?.DevObjects.Local.ToObservableCollection()
		   ?? throw new NullReferenceException();

	public ICommand<DevObject> EditDoCommand => new DelegateCommand<DevObject>(EditDo);

	private static void EditDo(DevObject devObject) => WindowsTransfer.EditProduct(devObject);
}