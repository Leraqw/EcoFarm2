

namespace Code
{
	public abstract class ButtonToScene : UnityEventAdapter
	{
		protected static ISceneTransferService SceneTransfer
			=> Contexts.sharedInstance.services.sceneTransferService.Value;
	}
}