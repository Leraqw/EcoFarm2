using System;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class UnityUiService : IUiService
	{
		[SerializeField] private ButtonsCollection _buttons;

		public IButtonsCollection Buttons => _buttons;

		[field: SerializeField] public GameObject CoinsView  { get; private set; }
		[field: SerializeField] public GameObject AppleView  { get; private set; }
		[field: SerializeField] public GameObject SellWindow { get; private set; }
	}
}