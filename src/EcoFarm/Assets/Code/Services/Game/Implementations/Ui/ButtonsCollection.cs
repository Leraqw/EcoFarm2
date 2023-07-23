using System;

using UnityEngine;

namespace Code
{
	[Serializable]
	public class ButtonsCollection : IButtonsCollection
	{
		[field: SerializeField] public GameObject Sell { get; private set; }
	}
}