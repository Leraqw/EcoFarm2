using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class OnToggleActivityButtonClickSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public OnToggleActivityButtonClickSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(TargetActivity, AttachedTo));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entities) => entities.ForEach(Toggle);

		private void Toggle(GameEntity button)
		{
			var activity = button.targetActivity;
			var window = GetWindowForButton(button);

			if (activity == true
			    && window.isRequirePreparation)
			{
				window.isPreparationInProcess = true;
				return;
			}

			window.ReplaceActivate(activity);
		}

		private GameEntity GetWindowForButton(GameEntity button)
			=> _contexts.game.GetEntityWithAttachableIndex(button.attachedTo);
	}
}