using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.EcoResources
{
	public sealed class ProduceResourceSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		public ProduceResourceSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Generator, EfficiencyCoefficient).NoneOf(Duration));

		protected override bool Filter(GameEntity entity) => entity.hasDuration == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Produce);

		private void Produce(GameEntity generator)
		{
			_contexts.game.energyResourceEntity.IncreaseResourceCurrentValue(generator.efficiencyCoefficient);
			generator.ReplaceDuration(1);
		}
	}
}