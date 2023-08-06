using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	public class TreeSO : DevelopmentObjectSO
	{
		[field: SerializeField] public ProductSO Product { get; private set; }
	}
}