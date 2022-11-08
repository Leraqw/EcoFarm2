using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class OnSellButtonClickSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public OnSellButtonClickSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(ButtonClick, ShowOnInvoke, AttachedTo));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Show);

		private void Show(GameEntity button)
		{
			var window = _contexts.game.GetEntityWithAttachableIndex(button.attachedTo);
			window.ReplaceEnabled(true);
		}
	}
}