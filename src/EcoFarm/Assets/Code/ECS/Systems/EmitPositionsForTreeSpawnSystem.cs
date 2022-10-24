using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems
{
	public sealed class EmitPositionsForTreeSpawnSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public EmitPositionsForTreeSpawnSystem(Contexts contexts) => _contexts = contexts;

		private ISceneObjectsService SceneObjectsService => _contexts.services.sceneObjectsService.Value;
		private IConfigService ConfigService => _contexts.services.configService.Value;

		public void Initialize()
			=> SceneObjectsService
			   .TreeSpawnPositions
			   .Take(ConfigService.TreesCount)
			   .ForEach(RequireTreeOn);

		private void RequireTreeOn(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .AddRequireTreeOnPosition(position);
	}
}