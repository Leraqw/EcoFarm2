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

		public LoadViewForEntitySystem(Contexts contexts, IResourcesService resourcesService, IUiService uiService)
			: base(contexts.game)
		{
			_viewRoot = new GameObject("View Root").transform;
			_resourcesService = resourcesService;
			_uiService = uiService;
		}

		private RectTransform UiRoot => _uiService.UiRoot;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AnyOf(RequireView, ViewPrefab));

		protected override bool Filter(GameEntity entity) => entity.hasView == false;

		protected override void Execute(List<GameEntity> entites)
			=> entites.ForEach(InstantiateView);

		private void InstantiateView(GameEntity e) => e.PerformRequiredView(Instantiate(e));

		private GameObject Instantiate(GameEntity e)
			=> e.isUiElement
				? Object.Instantiate(LoadPrefab(e), e.hasUiParent ? e.uiParent.Value : UiRoot)
				: GameObjectUtils.Instantiate(LoadPrefab(e), e.GetActualSpawnPosition(), _viewRoot);

		private GameObject LoadPrefab(GameEntity e)
			=> e.hasViewPrefab ? e.viewPrefab.Value : _resourcesService.LoadGameObject(e.requireView.Value);
	}
}