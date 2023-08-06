using UnityEngine;

namespace EcoFarm
{
	public class LevelButton : UnityEventAdapter
	{
		[SerializeField] private int _levelIndex;
		[SerializeField] private GameObject _completedView;

		public bool IsCompleted
		{
			get => _completedView.activeSelf;
			set => _completedView.SetActive(value);
		}

		private static Contexts Contexts => Contexts.sharedInstance;

		protected override void OnButtonClick()
		{
			Contexts.player.currentPlayerEntity.ReplaceSelectedLevel(_levelIndex);
			Contexts.services.sceneTransferService.Value.ToGameplayScene();
		}

		public void SetButtonEnabled(bool value) => Button.interactable = value;
	}
}