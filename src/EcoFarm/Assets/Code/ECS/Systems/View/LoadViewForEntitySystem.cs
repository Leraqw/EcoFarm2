using System.Collections.Generic;
using Code.Services.Interfaces;
using Code.Utils.StaticClasses;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.View
{
	public sealed class LoadViewForEntitySystem : ReactiveSystem<GameEntity>
	{
		private readonly ServicesContext _services;

		public LoadViewForEntitySystem(Contexts contexts)
			: base(contexts.game)
			=> _services = contexts.services;

		private IResourcesService Resources => _services.resourcesService.Value;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.RequireView);

		protected override bool Filter(GameEntity entity)
			=> entity.hasView == false;

		protected override void Execute(List<GameEntity> entites)
			=> entites.ForEach(Instantiate);

		private void Instantiate(GameEntity e) => GameObjectUtils.Instantiate(LoadPrefab(e), GetSpawnPosition(e));

		private GameObject LoadPrefab(GameEntity e) => Resources.LoadGameObject(e.requireView.Value);

		private static Vector2 GetSpawnPosition(GameEntity e)
			=> e.hasSpawnPosition ? e.spawnPosition.Value : Vector3.zero;
	}
}