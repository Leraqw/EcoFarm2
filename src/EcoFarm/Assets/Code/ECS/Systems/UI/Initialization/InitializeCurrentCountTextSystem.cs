using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.UI.Initialization
{
	public sealed class InitializeCurrentCountTextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeCurrentCountTextSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("CurrentCountText"))
			            .Do((e) => e.AddView(UI.WindowSell.CurrentValue.gameObject))
			            .Do((e) => e.AddText(0.ToString()));
	}
}