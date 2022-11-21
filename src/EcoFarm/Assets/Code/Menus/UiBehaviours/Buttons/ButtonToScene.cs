using Code.Services.Interfaces;
using Code.Unity.CustomTypes;
using UnityEngine;

namespace Code.Menus.UiBehaviours.Buttons
{
	public class ButtonToScene : UnityEventAdapter
	{
		[SerializeField] private SceneField _scene;

		private static ISceneTransferService SceneTransfer
			=> Contexts.sharedInstance.services.sceneTransferService.Value;

		protected override void OnButtonClick() => SceneTransfer.ToScene(_scene);
	}
}