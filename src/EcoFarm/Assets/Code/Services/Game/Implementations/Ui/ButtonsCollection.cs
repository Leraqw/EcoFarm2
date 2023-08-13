using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class ButtonsCollection : IButtonsCollection
	{
		[field: SerializeField] public GameObject Sell { get; private set; }
	}
}