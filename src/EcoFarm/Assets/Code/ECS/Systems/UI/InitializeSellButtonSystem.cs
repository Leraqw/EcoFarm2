using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class InitializeSellButtonSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IGroup<GameEntity> _windows;

		public InitializeSellButtonSystem(Contexts contexts)
		{
			_contexts = contexts;
			_windows = _contexts.game.GetGroup(AllOf(SellWindow, AttachableIndex));
		}

		public void Initialize() => _windows.ForEach(Bind);

		private void Bind(GameEntity window)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("ButtonSell"))
			            .Do((e) => e.AddAttachedTo(window.attachableIndex))
			            .Do((e) => e.isShowOnInvoke = true)
			            .Do((e) => e.AddView(_contexts.services.uiService.Value.Buttons.Sell));
	}
}