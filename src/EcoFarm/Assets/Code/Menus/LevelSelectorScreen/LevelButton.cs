using Code.Unity.CustomTypes;
using UnityEngine;

namespace Code.Menus.LevelSelectorScreen
{
	public class LevelButton : UnityEventAdapter
	{
		[SerializeField] private int _levelIndex;
		[SerializeField] private bool _isCompleted;
		[SerializeField] private SceneField _sceneField;

		protected override void OnButtonClick()
		{
			Debug.Log($"Level {_levelIndex} clicked");
		}
	}
}