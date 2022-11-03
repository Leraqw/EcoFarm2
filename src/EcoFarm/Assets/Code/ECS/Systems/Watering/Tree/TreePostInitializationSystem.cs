using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;

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

		private void PostInitialize(GameEntity tree) => tree.Do((e) => e.AddWatering(6)); // TODO: move to config
	}
}