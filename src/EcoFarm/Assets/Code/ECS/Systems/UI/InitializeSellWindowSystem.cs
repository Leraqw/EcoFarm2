using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.UI
{
	public sealed class InitializeSellWindowSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeSellWindowSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddEnabled(true))
			            // .Do((e) => e.AddView(_contexts.services.uiService.Value.SellWindow))
			            ;
	}
}