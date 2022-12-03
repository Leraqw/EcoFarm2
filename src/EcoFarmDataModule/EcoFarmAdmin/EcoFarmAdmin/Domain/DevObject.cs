using System;

namespace EcoFarmAdmin.Domain;

[Serializable]
public class DevObject
{
	public int     Id          { get; set; }
	public string? Title       { get; set; }
	public string? Description { get; set; }
	public int     Price       { get; set; }
}