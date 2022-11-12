using System.Collections.Generic;
using Code.Services.Interfaces;
using Code.Utils.Extensions.Entitas;
using Code.Utils.StaticClasses;
using Entitas;
using UnityEngine;
using static GameMatcher;

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
			_viewRoot = new GameObject("View Root").transform;
		}

		private IResourcesService Resources => _services.resourcesService.Value;

		private RectTransform UiRoot => _services.uiService.Value.UiRoot;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AnyOf(RequireView, ViewPrefab));

		protected override bool Filter(GameEntity entity) => entity.hasView == false;

		protected override void Execute(List<GameEntity> entites)
			=> entites.ForEach(InstantiateView);

		private void InstantiateView(GameEntity e) => e.PerformRequiredView(Instantiate(e));

		private GameObject Instantiate(GameEntity e)
			=> GameObjectUtils.Instantiate(LoadPrefab(e), e.GetActualSpawnPosition(), ViewRoot(e));

		private Transform ViewRoot(GameEntity entity) => entity.isUiElement ? UiRoot : _viewRoot;

		private GameObject LoadPrefab(GameEntity e)
			=> e.hasViewPrefab ? e.viewPrefab : Resources.LoadGameObject(e.requireView.Value);
	}
}