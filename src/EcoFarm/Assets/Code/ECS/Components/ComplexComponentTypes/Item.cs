using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class Item
	{
		[field: SerializeField] public ItemName Name  { get; private set; }
		[field: SerializeField] public int    Count { get; set; }

		public Item(ItemName name)
		{
			Name = name;
			Count = 0;
		}
	}
}