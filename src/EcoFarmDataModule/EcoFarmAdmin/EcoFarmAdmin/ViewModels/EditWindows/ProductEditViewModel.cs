using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class ProductEditViewModel : ViewModelBase
{
	private DevObject _devObject;

	public DevObject DevObject
	{
		get => _devObject;
		set
		{
			_devObject = value;
			RaisePropertiesChanged();
		}
	}
}