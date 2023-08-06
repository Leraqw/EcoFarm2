using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class TreeSO : DevelopmentObjectSO
	{
		[field: SerializeField] public ProductSO Product { get; private set; }
	}
}