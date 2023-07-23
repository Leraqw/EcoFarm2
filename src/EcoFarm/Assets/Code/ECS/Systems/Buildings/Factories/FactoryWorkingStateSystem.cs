using System.Collections.Generic;



using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class FactoryWorkingStateSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public FactoryWorkingStateSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private IFactoryConfig Balance => _contexts.GetConfiguration().Balance.Factory;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Factory, Ready, DurationUp).NoneOf(Duration));

		protected override bool Filter(GameEntity entity) => entity.hasDuration == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(StartWorking);

		private void StartWorking(GameEntity factory)
			=> factory
			   .Do((e) => e.isReady = false)
			   .Do((e) => e.isWorking = true)
			   .Do((e) => e.AddDuration(Balance.WorkingDuration))
		/**/;
	}
}