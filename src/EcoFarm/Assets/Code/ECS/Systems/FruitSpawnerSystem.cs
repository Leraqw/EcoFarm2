﻿using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants;

namespace Code.ECS.Systems
{
	public sealed class FruitSpawnerSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public FruitSpawnerSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.HasFruit);

		protected override bool Filter(GameEntity entity)
			=> true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(SpawnFruitFor);

		private void SpawnFruitFor(GameEntity tree)
		{
			var position = tree.spawnPosition.Value;
			var fruit = _contexts.game.CreateEntity();

			fruit.AddSpawnPosition(position + Vector2.up); // TODO: spawn on top of the tree
			fruit.AddRequireView(ResourcePath.ApplePrefab);
		}
	}
}