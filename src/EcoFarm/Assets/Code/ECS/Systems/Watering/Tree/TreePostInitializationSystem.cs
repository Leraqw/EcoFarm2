using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;
using static Code.Utils.StaticClasses.Constants.Balance.Tree;

namespace Code.ECS.Systems.Watering.Tree
{
	public sealed class TreePostInitializationSystem : ReactiveSystem<GameEntity>
	{
		public TreePostInitializationSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Tree);

		protected override bool Filter(GameEntity entity) => entity.hasWatering == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(PostInitialize);

		private static void PostInitialize(GameEntity tree) => tree.Do((e) => e.AddWatering(InitialWatering));
	}
}