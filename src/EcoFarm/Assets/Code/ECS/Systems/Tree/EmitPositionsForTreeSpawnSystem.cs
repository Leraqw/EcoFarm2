using System.Linq;
using Entitas;
using UnityEngine;

namespace EcoFarm
{
	public sealed class EmitPositionsForTreeSpawnSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly ISpawnPointsService _spawnPointsService;

		public EmitPositionsForTreeSpawnSystem(Contexts contexts, ISpawnPointsService spawnPointsService)
		{
			_contexts = contexts;
			_spawnPointsService = spawnPointsService;
		}

		private Level[] Levels => _contexts.game.storage.Value.Levels;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

		public void Initialize()
			=> _spawnPointsService
			   .Trees
			   .Take(Levels[SelectedLevel].TreesCount)
			   .ForEach(RequireTreeOn);

		private void RequireTreeOn(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .AddRequireTreeOnPosition(position);
	}
}