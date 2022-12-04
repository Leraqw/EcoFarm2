using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataBaseViewModel : ViewModelBase
{
	public IEnumerable<DevObject> DevObjects
		=> DataBaseConnection.CurrentContext?.DevObjects.Local.ToObservableCollection()
		   ?? throw new NullReferenceException();

	public ICommand<object> EditDoCommand => new DelegateCommand<object>(o => EditDo((DevObject)o));

	public void EditDo(DevObject devObject) => MessageBox.Show($"Edit {devObject.Title}");
}