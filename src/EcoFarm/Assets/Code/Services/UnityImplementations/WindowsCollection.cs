using System;
using Code.Services.Interfaces;
using Code.Unity.Containers;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class WindowsCollection : IWindowsCollection
	{
		[field: SerializeField] public WindowSell Sell  { get; private set; }
		[field: SerializeField] public GameObject Pause { get; private set; }
	}
}