using Code.Unity.Containers;
using UnityEngine;

namespace Code.Services.Game.Interfaces.Ui
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
		BuildView          BuildView  { get; }
	}
}