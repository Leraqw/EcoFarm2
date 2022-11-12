using System;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class UnityUiService : IUiService
	{
		[SerializeField] private ButtonsCollection _buttons;
		[SerializeField] private WindowsCollection _windows;

		public IButtonsCollection Buttons => _buttons;
		public IWindowsCollection Windows => _windows;

		[field: SerializeField] public RectTransform UiRoot     { get; private set; }
		[field: SerializeField] public RectTransform GoalsGroup { get; private set; }
		[field: SerializeField] public GameObject    GoalPrefab { get; private set; }
		[field: SerializeField] public GameObject    CoinsView  { get; private set; }
		[field: SerializeField] public GameObject    AppleView  { get; private set; }
	}
}