using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.Game.Interfaces
{
	public interface IUiService
	{
		GameObject         CoinsView  { get; }
		GameObject         AppleView  { get; }
		GameObject         GoalPrefab { get; }
		RectTransform      UiRoot     { get; }
		IWindowsCollection Windows    { get; }
		IButtonsCollection Buttons    { get; }
		RectTransform      GoalsGroup { get; }
		GameObject         TimerView  { get; }
	}
}