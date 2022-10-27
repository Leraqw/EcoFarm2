using System.Collections.Generic;
using Code.Services.Interfaces;
using Code.Utils.Extensions.Entitas;
using Code.Utils.StaticClasses;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.View
{
	public sealed class LoadViewForEntitySystem : ReactiveSystem<GameEntity>
	{
		private readonly ServicesContext _services;
		private readonly Transform _viewRoot;

		public LoadViewForEntitySystem(Contexts contexts)
			: base(contexts.game)
		{
			_services = contexts.services;
			_viewRoot = new GameObject("Ui Root").transform;
		}

		private IResourcesService Resources => _services.resourcesService.Value;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.RequireView);

		protected override bool Filter(GameEntity entity)
			=> entity.hasView == false;

		protected override void Execute(List<GameEntity> entites)
			=> entites.ForEach(InstantiateView);

		private void InstantiateView(GameEntity e) => e.PerformRequiredView(Instantiate(e));

		private GameObject Instantiate(GameEntity e)
			=> GameObjectUtils.Instantiate(LoadPrefab(e), e.GetActualSpawnPosition(), _viewRoot);

		private GameObject LoadPrefab(GameEntity e) => Resources.LoadGameObject(e.requireView.Value);
	}
}