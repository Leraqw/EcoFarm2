using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Code.Utils.StaticClasses;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Generators
{
	public sealed class StartCleaningPollutionSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _generators;

		public StartCleaningPollutionSystem(Contexts contexts) : base(contexts.game)
			=> _generators = contexts.game.GetGroup(CleanerGenerator);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(PollutionCoefficient);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Clean);

		private void Clean(GameEntity pollute)
			=> _generators.ForEach((g) => StartCleaning(g, pollute), @if: (g) => HasSameResource(g, pollute));

		private static bool HasSameResource(GameEntity generator, GameEntity pollute)
			=> generator.GetResource().resource.Value == pollute.pollution.Value;

		private void StartCleaning(GameEntity generator, GameEntity pollute)
		{
			generator
				.Do((e) => e.AddDuration(Constants.CleaningTime))
				.Do((e) => e.ReplaceEfficiencyCoefficient(pollute.pollutionCoefficient))
				.Do((e) => e.isWorking = true)
				;

			pollute
				.Do((e) => e.RemovePollutionCoefficient())
				.Do((e) => e.RemovePollution())
				;
		}
	}
}