using System;
using Code.Services.Game.Interfaces.Ui;
using Code.Unity.Containers;
using UnityEngine;

namespace Code.Services.Game.Implementations.Ui
{
	[Serializable]
	public class WindowsCollection : IWindowsCollection
	{
		[field: SerializeField] public WindowSell Sell  { get; private set; }
		[field: SerializeField] public GameObject Pause { get; private set; }
	}
}