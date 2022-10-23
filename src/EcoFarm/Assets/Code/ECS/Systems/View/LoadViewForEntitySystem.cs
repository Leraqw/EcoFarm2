using System.Collections.Generic;
using System.Linq;
using Code.Services.Interfaces;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.View
{
	public sealed class LoadViewForEntitySystem : ReactiveSystem<GameEntity>
	{
		private readonly ServicesContext _services;

		public LoadViewForEntitySystem(Contexts contexts)
			: base(contexts.game)
		{
			_services = contexts.services;
		}

		private IResourcesLoadService Resources => _services.resourcesLoadService.Value;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.RequireView);

		protected override bool Filter(GameEntity entity)
			=> entity.hasView == false;

		protected override void Execute(List<GameEntity> entites)
		{
			foreach (var prefab in entites.Select(LoadPrefab))
			{
				Object.Instantiate(prefab);
			}
		}

		private GameObject LoadPrefab(GameEntity e) => Resources.LoadGameObject(e.requireView.Value);
	}
}