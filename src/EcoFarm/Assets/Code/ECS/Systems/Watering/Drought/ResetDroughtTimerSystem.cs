using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Watering.Drought
{
	public sealed class ResetDroughtTimerSystem : ReactiveSystem<GameEntity>
	{
		public ResetDroughtTimerSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(DroughtTimer, DurationUp));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Reset);

		private void Reset(GameEntity entity) => entity.ResetDroughtTimer();
	}
}