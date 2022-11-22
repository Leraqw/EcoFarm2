using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.EcoResources
{
	public sealed class ProduceResourceSystem : ReactiveSystem<GameEntity>
	{
		public ProduceResourceSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Generator, EfficiencyCoefficient).NoneOf(Duration));

		protected override bool Filter(GameEntity entity) => entity.hasDuration == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(ProducePerSecond);

		private static void ProducePerSecond(GameEntity generator)
			=> generator
			   .Do((g) => g.Produce())
			   .Do((g) => g.ReplaceDuration(1))
		/**/;
	}
}