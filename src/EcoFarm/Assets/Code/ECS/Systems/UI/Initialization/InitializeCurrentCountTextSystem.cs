using Entitas;

namespace Code.ECS.Systems.UI.Initialization
{
	public sealed class InitializeCurrentCountTextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeCurrentCountTextSystem(Contexts contexts)
		{
			_contexts = contexts;
		}

		public void Initialize()
		{
			_contexts.game.CreateEntity()
			         .AddView(_contexts.services.uiService.Value.WindowSell.CurrentValue.gameObject);
		}
	}
}