using Code.Services.Game.Interfaces.Ui;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.UI.Initialization
{
	public sealed class InitializeSellWindowSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeSellWindowSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("SellWindow"))
			            .Do((e) => e.AddActivate(false))
			            .Do((e) => e.AddView(UI.Windows.Sell.gameObject))
			            .Do((e) => e.AddSellWindow(UI.Windows.Sell))
			            .Do((e) => e.AddAttachableIndex(e.creationIndex))
			            .Do((e) => e.isRequirePreparation = true);
	}
}