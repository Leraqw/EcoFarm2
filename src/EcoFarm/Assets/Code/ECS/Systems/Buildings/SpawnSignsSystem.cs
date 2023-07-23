using Entitas;
using UnityEngine;

namespace Code
{
	public sealed class SpawnSignsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnSignsSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

		public void Initialize() => SpawnPointsService.Buildings.ForEach(Spawn);

		private void Spawn(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Sign"))
			            .Do((e) => e.AddPosition(position))
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.Sign))
			            .Do((e) => e.isSign = true)
			            .MakeAttachable();
	}
}