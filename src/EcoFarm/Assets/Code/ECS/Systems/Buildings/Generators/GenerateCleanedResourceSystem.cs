using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Generators
{
	public sealed class GenerateCleanedResourceSystem : ReactiveSystem<GameEntity>
	{
		public GenerateCleanedResourceSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(CleanerGenerator, DurationUp));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Generate);

		private void Generate(GameEntity generator) => generator.Do((g) => g.Produce());
	}
}