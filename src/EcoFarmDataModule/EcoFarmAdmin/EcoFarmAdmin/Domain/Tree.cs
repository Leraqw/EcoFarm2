using System;

namespace EcoFarmAdmin.Domain;

[Serializable]
public class Tree : DevObject
{
	public Product Product { get; set; } = null!;
}