using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Watering.Bucket
{
	public sealed class WaterNearTreeSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _trees;

		public WaterNearTreeSystem(Contexts contexts)
			: base(contexts.game)
			=> _trees = contexts.game.GetGroup(GameMatcher.Tree);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Filled.Removed());

		protected override bool Filter(GameEntity entity) => entity.hasRadius && entity.hasPosition;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(WaterTrees);

		private void WaterTrees(GameEntity bucket) => _trees.ForEach(WaterTree, @if: (t) => IsNear(t, bucket));

		private static void WaterTree(GameEntity tree) => tree.isWatered = true;

		private static bool IsNear(GameEntity tree, GameEntity bucket)
			=> Vector2.Distance(bucket.GetActualPosition(), tree.GetActualPosition()) <= bucket.radius;
	}
}