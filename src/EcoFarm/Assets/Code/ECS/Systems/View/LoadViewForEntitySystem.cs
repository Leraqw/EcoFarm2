using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class LoadViewForEntitySystem : ReactiveSystem<GameEntity>
	{
		private readonly Transform _viewRoot;
		private readonly IResourcesService _resourcesService;
		private readonly IUiService _uiService;
		private readonly Injector _injector;

		public LoadViewForEntitySystem
		(
			Contexts contexts,
			IResourcesService resourcesService,
			IUiService uiService,
			Injector injector
		)
			: base(contexts.game)
		{
			_viewRoot = new GameObject("View Root").transform;
			_resourcesService = resourcesService;
			_uiService = uiService;
			_injector = injector;
		}

		private RectTransform UiRoot => _uiService.UiRoot;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AnyOf(RequireView, ViewPrefab));

		protected override bool Filter(GameEntity entity) => entity.hasView == false;

		protected override void Execute(List<GameEntity> entites)
			=> entites.ForEach(InstantiateView);

		private void InstantiateView(GameEntity e)
		{
			var gameObject = Instantiate(e);
			_injector.InjectGameObject(gameObject);
			e.PerformViewRequest(gameObject);
		}

		private GameObject Instantiate(GameEntity e)
			=> e.isUiElement ? InstantiateUi(e) : InstantiateGameObject(e);

		private GameObject InstantiateUi(GameEntity e)
			=> Object.Instantiate(LoadPrefab(e), e.hasUiParent ? e.uiParent.Value : UiRoot);

		private GameObject InstantiateGameObject(GameEntity e)
			=> Utils.GameObject.Instantiate(LoadPrefab(e), e.GetActualSpawnPosition(), _viewRoot);

		private GameObject LoadPrefab(GameEntity e)
			=> e.hasViewPrefab ? e.viewPrefab.Value : _resourcesService.LoadGameObject(e.requireView.Value);
    }
}