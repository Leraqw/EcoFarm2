using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Game.Interfaces;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Buildings
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
			            .Do((e) => e.AddAttachableIndex())
			/**/;
	}

	public static class AttachExtensions
	{
		public static GameEntity AttachTo(this GameEntity @this, GameEntity attachable) 
			=> @this.Do((e) => e.AddAttachedTo(attachable.attachableIndex));
		
		public static GameEntity AddAttachableIndex(this GameEntity @this) 
			=> @this.Do((e) => e.AddAttachableIndex(@this.creationIndex));
	}
}