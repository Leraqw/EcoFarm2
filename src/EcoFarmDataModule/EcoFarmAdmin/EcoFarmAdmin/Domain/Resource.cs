using System;
using System.ComponentModel;

namespace EcoFarmAdmin.Domain;

[Serializable]
public class Resource : INotifyPropertyChanged
{
	public int    Id    { get; set; }
	public string Title { get; set; } = null!;

	public event PropertyChangedEventHandler? PropertyChanged;
}