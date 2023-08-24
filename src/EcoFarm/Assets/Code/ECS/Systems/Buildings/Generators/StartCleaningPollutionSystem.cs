using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class StartCleaningPollutionSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _generators;
		private readonly IConfigurationService _configurationService;

		public StartCleaningPollutionSystem(Contexts contexts, IConfigurationService configurationService)
			: base(contexts.game)
		{
			_configurationService = configurationService;
			_generators = contexts.game.GetGroup(CleanerGenerator);
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(PollutionCoefficient);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Clean);

		private void Clean(GameEntity pollute)
			=> _generators.ForEach((g) => StartCleaning(g, pollute), @if: (g) => HasSameResource(g, pollute));

		private static bool HasSameResource(GameEntity generator, GameEntity pollute)
			=> pollute.hasPollution && generator.GetResource().resource.Value == pollute.pollution.Value;

		private void StartCleaning(GameEntity generator, GameEntity pollute)
		{
			generator
				.Do((e) => e.AddDuration(_configurationService.Balance.Factory.WorkingDuration))
				.Do((e) => e.ReplaceEfficiencyCoefficient(pollute.pollutionCoefficient.Value))
				.Do((e) => e.isWorking = true)
				;

			pollute
				.Do((e) => e.RemovePollutionCoefficient())
				.Do((e) => e.RemovePollution())
				;
		}
	}
}