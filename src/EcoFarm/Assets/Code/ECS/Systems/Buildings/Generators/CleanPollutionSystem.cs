using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Code.Utils.StaticClasses;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Generators
{
	public sealed class CleanPollutionSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _generators;

		public CleanPollutionSystem(Contexts contexts) : base(contexts.game)
			=> _generators = contexts.game.GetGroup(CleanerGenerator);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Pollute);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Clean);

		private void Clean(GameEntity pollute)
			=> _generators.ForEach(g => StartCleaning(g, pollute.pollute), @if: pollute.HasSameResource);

		private void StartCleaning(GameEntity generator, int polluteValue)
			=> generator
			   .Do((e) => e.AddDuration(Constants.CleaningTime))
			   .Do((e) => e.ReplaceEfficiencyCoefficient(polluteValue))
		/**/;
	}
}