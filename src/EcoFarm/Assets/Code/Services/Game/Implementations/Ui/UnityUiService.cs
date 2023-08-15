using System;


using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class UnityUiService : IUiService
	{
		[SerializeField] private WindowsCollection _windows;

		public IWindowsCollection Windows => _windows;

		[field: SerializeField] public RectTransform UiRoot     { get; private set; }
		[field: SerializeField] public RectTransform GoalsGroup { get; private set; }
		[field: SerializeField] public GameObject    GoalPrefab { get; private set; }
		[field: SerializeField] public GameObject    CoinsView  { get; private set; }
		[field: SerializeField] public GameObject    AppleView  { get; private set; }
		[field: SerializeField] public GameObject    TimerView  { get; private set; }
		[field: SerializeField] public BuildView     BuildView  { get; private set; }
		[field: SerializeField] public PlayerChoiceView PlayerChoiceView { get; private set; }
	}
}