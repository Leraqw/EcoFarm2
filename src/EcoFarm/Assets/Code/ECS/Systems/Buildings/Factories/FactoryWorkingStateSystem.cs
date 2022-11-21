using System.Collections.Generic;
using Code.ECS.Systems.Watering.Bucket;
using Code.Utils.Extensions;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Factories
{
	public sealed class FactoryWorkingStateSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public FactoryWorkingStateSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Factory, Ready, DurationUp));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(StartWorking);

		private void StartWorking(GameEntity factory)
			=> factory
			   .Do((e) => e.isWorking = true)
			   .Do((e) => e.ReplaceDuration(_contexts.GetConfiguration().Balance.Factory.WorkingDuration))
		/**/;
	}
}