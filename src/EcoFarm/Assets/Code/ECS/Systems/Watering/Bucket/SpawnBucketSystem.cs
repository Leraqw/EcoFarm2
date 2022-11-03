﻿using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using static Code.Utils.StaticClasses.Constants;
using static Code.Utils.StaticClasses.Constants.Balance.Bucket;

namespace Code.ECS.Systems.Watering.Bucket
{
	public sealed class SpawnBucketSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBucketSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Bucket"))
			            .Do((e) => e.AddRequireView(ResourcePath.Bucket))
			            .Do((e) => e.AddRadius(Radius))
			            .Do((e) => e.isDraggable = true)
			            .Do((e) => e.AddPosition(SpawnPointsService.Bucket))
			            .Do((e) => e.AddSpawnPosition(e.position));
	}
}