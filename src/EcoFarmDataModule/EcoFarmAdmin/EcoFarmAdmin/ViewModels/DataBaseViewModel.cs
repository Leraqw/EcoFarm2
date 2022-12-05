using System;
using System.Collections.Generic;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataBaseViewModel : ViewModelBase
{
	public IEnumerable<DevObject> DevObjects
		=> DataBaseConnection.CurrentContext.DevObjects.Local.ToObservableCollection();

	public ICommand<DevObject> EditDevObject
		=> new DelegateCommand<DevObject>((@do) => DataEditModel.EditProduct(ref @do));
}