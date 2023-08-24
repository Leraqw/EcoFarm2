using Entitas;

namespace EcoFarm
{
	public sealed class InitializePauseWindowSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;

		public InitializePauseWindowSystem(Contexts contexts, IUiService uiService)
		{
			_contexts = contexts;
			_uiService = uiService;
		}

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("PauseWindow"))
			            .Do((e) => e.AddActivate(false))
			            .Do((e) => e.AddView(_uiService.Windows.Pause))
			            .Do((e) => e.MakeAttachable());
	}
}