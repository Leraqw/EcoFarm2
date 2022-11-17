using Code.Services.Interfaces;
using Code.Unity.CustomTypes;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Menus.UiBehaviours.Buttons
{
	public class ButtonToScene : MonoBehaviour
	{
		[SerializeField] private Button _button;
		[SerializeField] private SceneField _scene;

		private static ISceneTransferService SceneTransfer
			=> Contexts.sharedInstance.services.sceneTransferService.Value;

		private void OnEnable() => _button.onClick.AddListener(ToGameplayScene);

		private void OnDisable() => _button.onClick.RemoveListener(ToGameplayScene);

		private void ToGameplayScene() => SceneTransfer.ToScene(_scene);
	}
}