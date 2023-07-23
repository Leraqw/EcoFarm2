using System;

using UnityEngine;

namespace Code
{
	[Serializable]
	public class WarehouseConfig : IWarehouseConfig
	{
		[field: SerializeField] public float PickupDuration { get; private set; } = 0.5f;
	}
}