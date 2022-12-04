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
}