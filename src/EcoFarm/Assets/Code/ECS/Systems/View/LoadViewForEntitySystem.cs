using System.Collections.Generic;



using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
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
			=> e.isUiElement
				? Object.Instantiate(LoadPrefab(e), e.hasUiParent ? e.uiParent.Value : UiRoot)
				: GameObjectUtils.Instantiate(LoadPrefab(e), e.GetActualSpawnPosition(), _viewRoot);

		private GameObject LoadPrefab(GameEntity e)
			=> e.hasViewPrefab ? e.viewPrefab.Value : Resources.LoadGameObject(e.requireView.Value);
	}
}