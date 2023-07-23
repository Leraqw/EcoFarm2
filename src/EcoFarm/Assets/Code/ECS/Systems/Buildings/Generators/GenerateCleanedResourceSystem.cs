using System.Collections.Generic;


using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class GenerateCleanedResourceSystem : ReactiveSystem<GameEntity>
	{
		public GenerateCleanedResourceSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(CleanerGenerator, DurationUp));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Generate);

		private void Generate(GameEntity generator)
			=> generator.Do((g) => g.Produce())
			            .Do((e) => e.isWorking = false)
		/**/;
	}
}