using Code.Unity.CustomTypes;
using UnityEngine;

namespace Code.Menus.LevelSelectorScreen
{
	public class LevelButton : UnityEventAdapter
	{
		[SerializeField] private int _levelIndex;
		[SerializeField] private SceneField _sceneField;
		[SerializeField] private bool _isCompleted;
		[SerializeField] private GameObject _completedView;

		private static Contexts Contexts => Contexts.sharedInstance;

		protected override void OnButtonClick()
		{
			Contexts.player.currentPlayerEntity.ReplaceSelectedLevel(_levelIndex);
			Contexts.services.sceneTransferService.Value.ToScene(_sceneField);
		}

		private void OnValidate() => ActualizeCompleted();

		private void ActualizeCompleted() => _completedView.SetActive(_isCompleted);
	}
}