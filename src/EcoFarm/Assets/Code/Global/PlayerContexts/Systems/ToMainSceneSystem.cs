using Entitas;

namespace Code.Global.PlayerContexts.Systems
{
	public sealed class ToMainSceneSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public ToMainSceneSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize() => _contexts.services.sceneTransferService.Value.ToMainMenuScene();
	}
}