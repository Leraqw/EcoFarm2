using System.Collections.Generic;
using Entitas;
using Zenject;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class FactoryWorkingStateSystem : ReactiveSystem<GameEntity>
	{
		private readonly IConfigurationService _configurationService;

		[Inject]
		public FactoryWorkingStateSystem(Contexts contexts, IConfigurationService configurationService)
			: base(contexts.game)
		{
			_configurationService = configurationService;
		}

		private IFactoryConfig Balance => _configurationService.Balance.Factory;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(GameMatcher.Factory, Ready, DurationUp).NoneOf(Duration));

		protected override bool Filter(GameEntity entity) => entity.hasDuration == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(StartWorking);

		private void StartWorking(GameEntity factory)
			=> factory
			   .Do((e) => e.isReady = false)
			   .Do((e) => e.isWorking = true)
			   .Do((e) => e.AddDuration(Balance.WorkingDuration));
	}
}