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
			=> context.CreateCollector(AllOf(DroughtTimer));

		protected override bool Filter(GameEntity entity) => entity.hasDuration == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Reset);

		private static void Reset(GameEntity entity) => entity.ResetDroughtTimer();
	}
}