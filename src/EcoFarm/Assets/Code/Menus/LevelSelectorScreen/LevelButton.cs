using Code.Menus;
using Code.Unity.CustomTypes;
using UnityEngine;

namespace EcoFarm.Code.Menus.LevelSelectorScreen
{
	public class LevelButton : UnityEventAdapter
	{
		[SerializeField] private int _levelIndex;
		[SerializeField] private SceneField _sceneField;
		[SerializeField] private bool _isCompleted;
		[SerializeField] private GameObject _completedView;

		protected override void OnButtonClick() => Debug.Log($"Level {_levelIndex} clicked");

		private void OnValidate() => ActualizeCompleted();

		private void ActualizeCompleted() => _completedView.SetActive(_isCompleted);
	}
}