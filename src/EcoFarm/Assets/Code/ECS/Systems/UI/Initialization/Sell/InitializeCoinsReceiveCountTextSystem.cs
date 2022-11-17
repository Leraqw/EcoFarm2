using Code.Services.Game.Interfaces.Ui;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.UI.Initialization.Sell
{
	public sealed class InitializeCoinsReceiveCountTextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeCoinsReceiveCountTextSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Coins Receive Count"))
			            .Do((e) => e.AddView(UI.Windows.Sell.CoinsReceiveCount.gameObject))
			            .Do((e) => e.AddText(0.ToString()));
	}
}