using Zenject;

namespace EcoFarm
{
	public abstract class ButtonToScene : UnityEventAdapter
	{
		protected ISceneTransferService SceneTransfer { get; private set; }


		[Inject] // TODO: check will it inject
		public void Construct(ISceneTransferService sceneTransferService)
			=> SceneTransfer = sceneTransferService;
	}
}