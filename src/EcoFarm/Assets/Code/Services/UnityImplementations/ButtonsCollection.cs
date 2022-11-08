using System;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class ButtonsCollection : IButtonsCollection
	{
		[field: SerializeField] public GameObject Sell { get; private set; }
	}
}