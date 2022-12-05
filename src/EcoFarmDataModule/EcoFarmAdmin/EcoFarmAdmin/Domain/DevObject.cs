using System;
using System.ComponentModel;

namespace EcoFarmAdmin.Domain;

[Serializable]
public class DevObject : INotifyPropertyChanged
{
	private string? _title;
	private string? _description;
	private int _price;
	public int Id { get; set; }

	public string? Title
	{
		get => _title;
		set
		{
			OnPropertyChanged(nameof(Title));
			_title = value;
		}
	}

	public string? Description
	{
		get => _description;
		set
		{
			OnPropertyChanged(nameof(Description));
			_description = value;
		}
	}

	public int Price
	{
		get => _price;
		set
		{
			OnPropertyChanged(nameof(Price));
			_price = value;
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public DevObject Clone() => (DevObject)MemberwiseClone();

	public void SetFrom(DevObject other)
	{
		Id = other.Id;
		Title = other.Title;
		Description = other.Description;
		Price = other.Price;
	}

	private void OnPropertyChanged(string propertyName)
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}