using System.Linq;
using Code.Services.Game.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;
using LevelData = EcoFarmModel.Level;

namespace Code.ECS.Systems.Tree
{
	public sealed class EmitPositionsForTreeSpawnSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public EmitPositionsForTreeSpawnSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private LevelData[] Levels => _contexts.game.storage.Value.Levels;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel;

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