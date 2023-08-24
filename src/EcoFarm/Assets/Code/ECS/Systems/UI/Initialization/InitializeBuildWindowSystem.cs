


using Entitas;

namespace EcoFarm
{
	public sealed class InitializeBuildWindowSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;

		public InitializeBuildWindowSystem(Contexts contexts, IUiService uiService)
		{
			_contexts = contexts;
			_uiService = uiService;
		}

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("BuildWindow"))
			            .Do((e) => e.AddActivate(false))
			            .Do((e) => e.AddView(_uiService.Windows.Build.gameObject))
			            .Do((e) => e.AddBuildWindow(_uiService.Windows.Build))
			            .Do((e) => e.MakeAttachable())
			            .Do((e) => e.isRequirePreparation = true);
	}
}