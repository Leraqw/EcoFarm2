using Code.Services.Game.Interfaces.Ui;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.UI.Initialization
{
	public sealed class InitializePauseWindowSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializePauseWindowSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("PauseWindow"))
			            .Do((e) => e.AddActivate(false))
			            .Do((e) => e.AddView(UI.Windows.Pause))
			            .Do((e) => e.MakeAttachable());
	}
}