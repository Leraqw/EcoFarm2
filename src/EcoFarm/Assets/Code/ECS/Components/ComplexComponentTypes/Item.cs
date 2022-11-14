using System;
using UnityEngine;

namespace Code.ECS.Components.ComplexComponentTypes
{
	[Serializable]
	public class Item
	{
		[field: SerializeField] public string Name  { get; private set; }
		[field: SerializeField] public int    Count { get; set; }

		public Item(string name)
		{
			Name = name;
			Count = 0;
		}
	}
}