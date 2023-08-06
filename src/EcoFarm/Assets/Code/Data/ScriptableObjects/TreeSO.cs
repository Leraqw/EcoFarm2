using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class TreeSO : DevObjectSO
	{
		[field: SerializeField] public ProductSO Product { get; private set; }
	}
}