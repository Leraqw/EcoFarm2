using System.Linq;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Tree
{
	public sealed class SpawnBedsPlugsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBedsPlugsSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IDataService DataService => _contexts.services.dataService.Value;

		private IResourcePathConfig ResourcePath => _contexts.GetConfiguration().ResourcePath;

		public void Initialize()
			=> SpawnPointsService
			   .Trees
			   .Skip(DataService.TreesCount)
			   .ForEach(SpawnPlug);

		private void SpawnPlug(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddRequireView(ResourcePath.Prefab.BedPlug))
			            .Do((e) => e.AddSpawnPosition(position))
			            .Do((e) => e.AddDebugName("BedPlug"));
	}
}