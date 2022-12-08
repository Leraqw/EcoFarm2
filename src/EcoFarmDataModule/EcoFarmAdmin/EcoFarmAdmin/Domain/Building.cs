using System;

namespace EcoFarmAdmin.Domain;

[Serializable]
public class Building : DevObject
{
	public Resource Resource    { get; set; } = null!;
	public int      Coefficient { get; set; }
}