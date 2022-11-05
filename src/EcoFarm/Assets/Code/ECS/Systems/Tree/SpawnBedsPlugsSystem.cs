using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants.ResourcePath.Prefab;

namespace Code.ECS.Systems.Tree
{
	public sealed class SpawnBedsPlugsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBedsPlugsSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;
		private IDataBaseService DataBaseService => _contexts.services.dataBaseService.Value;

		public void Initialize()
			=> SpawnPointsService
			   .Trees
			   .Skip(DataBaseService.TreesCount)
			   .ForEach(SpawnPlug);

		private void SpawnPlug(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddRequireView(BedPlug))
			            .Do((e) => e.AddSpawnPosition(position))
			            .Do((e) => e.AddDebugName("BedPlug"));
	}
}