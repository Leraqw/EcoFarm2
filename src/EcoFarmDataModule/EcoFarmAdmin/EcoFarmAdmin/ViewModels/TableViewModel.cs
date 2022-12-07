using System;
using System.Collections.ObjectModel;
using System.Windows;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public abstract class TableViewModel<T> : ViewModelBase
	where T : class, new()
{
	public TableViewModel() => Refresh();

	public T?         SelectedItem           { get; set; }
	public Visibility HasChangesAsVisibility { get; set; }

	public bool IsSelected => SelectedItem != null;

	public ObservableCollection<T> Collection => DataBaseConnection.Observable<T>();

	public ObservableCollection<DevObject> DevObjects => DataBaseConnection.Observable<DevObject>();
	public ObservableCollection<Product>   Products   => DataBaseConnection.Observable<Product>();
	public ObservableCollection<Tree>      Trees      => DataBaseConnection.Observable<Tree>();

	public ICommand<object> Add => new DelegateCommand(AddItem);

	public ICommand<T> Delete
		=> new DelegateCommand<T>
		(
			DeleteItem,
			(_) => IsSelected
		);

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

	private static void AddItem() => DataBaseConnection.CurrentContext.GetTable<T>().Add(new T());

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

	protected void Refresh() => HasChangesAsVisibility = DataBaseConnection.HasChanges.AsVisibility();
}