using Code.Services.Game.Interfaces.Ui;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.UI.Initialization
{
	public sealed class InitializeBuildWindowSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeBuildWindowSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("BuildWindow"))
			            .Do((e) => e.AddActivate(false))
			            .Do((e) => e.AddView(UI.Windows.Build.gameObject))
			            .Do((e) => e.AddBuildWindow(UI.Windows.Build))
			            .Do((e) => e.AddAttachableIndex(e.creationIndex))
			            .Do((e) => e.isRequirePreparation = true);
	}
}