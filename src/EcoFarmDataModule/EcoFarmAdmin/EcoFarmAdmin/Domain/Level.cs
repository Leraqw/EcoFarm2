using System;
using System.ComponentModel;

namespace EcoFarmAdmin.Domain;

[Serializable]
public class Level : INotifyPropertyChanged
{
	public int     Id         { get; set; }
	public float   Order      { get; set; }
	public string? Commentary { get; set; }

	public event PropertyChangedEventHandler? PropertyChanged;
}