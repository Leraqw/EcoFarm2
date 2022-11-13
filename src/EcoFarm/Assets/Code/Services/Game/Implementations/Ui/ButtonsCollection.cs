using System;
using Code.Services.Game.Interfaces.Ui;
using UnityEngine;

namespace Code.Services.Game.Implementations.Ui
{
	[Serializable]
	public class ButtonsCollection : IButtonsCollection
	{
		[field: SerializeField] public GameObject Sell { get; private set; }
	}
}