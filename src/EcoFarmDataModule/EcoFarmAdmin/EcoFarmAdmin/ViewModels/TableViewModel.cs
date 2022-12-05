using System;
using System.Collections.ObjectModel;
using System.Windows;
using DevExpress.Mvvm;

namespace EcoFarmAdmin.ViewModels;

public abstract class TableViewModel<T> : DataBaseViewModel
	where T : class, new()
{
	public TableViewModel() => Refresh();

	public T?         SelectedItem           { get; set; }
	public Visibility HasChangesAsVisibility { get; set; }

	public bool Selected => SelectedItem != null;

	public ObservableCollection<T> Collection
		=> DataBaseConnection.CurrentContext.GetTable<T>().Local.ToObservableCollection();

	public ICommand<object> Add => new DelegateCommand(AddItem);

	public ICommand<T> Delete
		=> new DelegateCommand<T>
		(
			DeleteItem,
			(_) => Selected
		);

	public static void AddItem() => DataBaseConnection.CurrentContext.GetTable<T>().Add(new T());

	private static void DeleteItem(T item)
	{
		try
		{
			DataBaseConnection.CurrentContext.GetTable<T>().Remove(item);
		}
		catch (Exception e)
		{
			MessageBox.Show(e.Message);
		}
	}

	public ICommand<object> SaveChanges
		=> new DelegateCommand
		(
			() => DataBaseConnection.CurrentContext.SaveChanges(),
			() =>
			{
				Refresh();
				return DataBaseConnection.HasChanges;
			}
		);

	private void Refresh() => HasChangesAsVisibility = DataBaseConnection.HasChanges.AsVisibility();
}