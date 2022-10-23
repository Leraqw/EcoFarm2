using System.Collections.Generic;
using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Code.ECS.Systems.View
{
	public sealed class LoadViewForEntitySystem : ReactiveSystem<GameEntity>
	{
		private readonly ServicesContext _services;

		public LoadViewForEntitySystem(Contexts contexts)
			: base(contexts.game)
			=> _services = contexts.services;

		private IResourcesLoadService Resources => _services.resourcesLoadService.Value;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.RequireView);

		protected override bool Filter(GameEntity entity)
			=> entity.hasView == false;

		protected override void Execute(List<GameEntity> entites)
			=> entites
			   .Select(LoadPrefab)
			   .ForEach(Instantiate);

		private GameObject LoadPrefab(GameEntity e) => Resources.LoadGameObject(e.requireView.Value);
		
		private void Instantiate(GameObject prefab) => Object.Instantiate(prefab);
	}
}