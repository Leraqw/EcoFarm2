using System.Linq;
using Entitas;
using UnityEngine;

namespace EcoFarm
{
	public sealed class EmitPositionsForTreeSpawnSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public EmitPositionsForTreeSpawnSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private LevelSO[] Levels => _contexts.game.storage.Value.Levels;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

		public void Initialize()
			=> SpawnPointsService
			   .Trees
			   .Take(Levels[SelectedLevel].TreesCount)
			   .ForEach(RequireTreeOn);

		private void RequireTreeOn(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .AddRequireTreeOnPosition(position);
	}
}