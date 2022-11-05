using System.Collections.Generic;
using Code.Services.Interfaces.Config.BalanceConfigs;
using Entitas;

namespace Code.ECS.Systems.Watering.Tree
{
	public sealed class TreePostInitializationSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public TreePostInitializationSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private ITreeConfig Configuration => _contexts.services.configurationService.Value.Balance.Tree;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Tree);

		protected override bool Filter(GameEntity entity) => entity.hasWatering == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(PostInitialize);

		private void PostInitialize(GameEntity tree) => tree.AddWatering(Configuration.InitialWatering);
	}
}