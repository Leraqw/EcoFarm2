using System.Linq;
using Entitas;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public sealed class EmitPositionsForTreeSpawnSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly ISpawnPointsService _spawnPointsService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public EmitPositionsForTreeSpawnSystem
		(
			Contexts contexts,
			ISpawnPointsService spawnPointsService,
			GameEntity.Factory gameEntityFactory
		)
		{
			_contexts = contexts;
			_spawnPointsService = spawnPointsService;
			_gameEntityFactory = gameEntityFactory;
		}

		private Level[] Levels => _contexts.game.storage.Value.Levels;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

		public void Initialize()
			=> _spawnPointsService
			   .Trees
			   .Take(Levels[SelectedLevel].TreesCount)
			   .ForEach(RequireTreeOn);

		private void RequireTreeOn(Vector2 position)
			=> _gameEntityFactory.Create().AddRequireTreeOnPosition(position);
	}
}