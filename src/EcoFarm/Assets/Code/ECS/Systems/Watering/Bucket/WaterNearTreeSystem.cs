using System.Collections.Generic;
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
			=> context.CreateCollector(AllOf(MouseUp, Filled));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(WaterTrees);

		private void WaterTrees(GameEntity bucket)
		{
			foreach (var tree in _trees)
			{
				if (Vector2.Distance(bucket.position, tree.position) <= bucket.radius)
				{
					tree.isWatered = true;
				}
			}
		}
	}
}