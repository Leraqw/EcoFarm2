using Code.Services.Interfaces;

namespace Code.Menus.UiBehaviours.Buttons
{
	public abstract class ButtonToScene : UnityEventAdapter
	{
		protected static ISceneTransferService SceneTransfer
			=> Contexts.sharedInstance.services.sceneTransferService.Value;
	}
}