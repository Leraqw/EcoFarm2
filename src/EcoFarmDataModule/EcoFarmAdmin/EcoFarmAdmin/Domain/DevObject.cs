using System;
using System.ComponentModel;

namespace EcoFarmAdmin.Domain;

[Serializable]
public class DevObject : INotifyPropertyChanged
{
	public int     Id          { get; set; }
	public string? Title       { get; set; }
	public string? Description { get; set; }
	public int     Price       { get; set; }

	public event PropertyChangedEventHandler? PropertyChanged;

	public DevObject Clone() => (DevObject)MemberwiseClone();

	public void SetFrom(DevObject other)
	{
		Id = other.Id;
		Title = other.Title;
		Description = other.Description;
		Price = other.Price;
	}

	public void OnPropertyChanged() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
}