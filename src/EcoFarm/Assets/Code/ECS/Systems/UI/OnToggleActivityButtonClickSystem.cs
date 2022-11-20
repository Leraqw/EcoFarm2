using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class OnToggleActivityButtonClickSystem : ReactiveSystem<GameEntity>
	{
		public OnToggleActivityButtonClickSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(TargetActivity, AttachedTo));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entities) => entities.ForEach(Toggle);

		private static void Toggle(GameEntity button)
		{
			var activity = button.targetActivity;
			var window = button.GetAttachableEntity();

			if (activity == true
			    && window.isRequirePreparation)
			{
				window.isPreparationInProcess = true;
				return;
			}

			window.ReplaceActivate(activity);
		}
	}
}