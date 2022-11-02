using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Tree
{
	public sealed class EmitPositionsForTreeSpawnSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public EmitPositionsForTreeSpawnSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;
		private IDataBaseService DataBaseService => _contexts.services.dataBaseService.Value;

		public void Initialize()
			=> SpawnPointsService
			   .Trees
			   .Take(DataBaseService.TreesCount)
			   .ForEach(RequireTreeOn);

		private void RequireTreeOn(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .AddRequireTreeOnPosition(position);
	}
}