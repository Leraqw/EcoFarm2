using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class ToMainSceneSystem : IInitializeSystem
	{
		private readonly ISceneTransferService _sceneTransferService;

		[Inject]
		public ToMainSceneSystem(ISceneTransferService sceneTransferService)
			=> _sceneTransferService = sceneTransferService;

		public void Initialize() => _sceneTransferService.ToMainMenuScene();
	}
}