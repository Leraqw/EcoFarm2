using System;
using System.ComponentModel;

namespace EcoFarmAdmin.Domain;

[Serializable]
public class Level : INotifyPropertyChanged
{
	public int Id    { get; set; }
	public int Order { get; set; }

	public event PropertyChangedEventHandler? PropertyChanged;
}