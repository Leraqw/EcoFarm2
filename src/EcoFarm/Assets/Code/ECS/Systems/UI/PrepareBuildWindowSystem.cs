using System.Collections.Generic;
using Code.Unity.ViewListeners;
using Code.Utils.Extensions;
using EcoFarmDataModule;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class PrepareBuildWindowSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public PrepareBuildWindowSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IEnumerable<Building> Buildings => _contexts.game.storage.Value.Buildings;

		private BuildView BuildView => _contexts.services.uiService.Value.BuildView;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(PreparationInProcess, BuildWindow));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Prepare);

		private void Prepare(GameEntity window)
			=> window.Do(CleanBuildingList)
			         .Do(FillBuildingsList)
			         .Do(EndPreparations);

		private static void CleanBuildingList(GameEntity window)
			=> window.buildWindow.Value.ContentView.transform.DestroyChildrens();

		private void FillBuildingsList(GameEntity window) => Buildings.ForEach((b) => BindView(b, BuildView, window));

		private void BindView(Building building, Component prefab, GameEntity window)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.isUiElement = true)
			            .Do((e) => e.AddUiParent(window.buildWindow.Value.ContentView))
			            .Do((e) => e.AddBuilding(building))
			            .Do((e) => e.AddViewPrefab(prefab.gameObject));

		private static void EndPreparations(GameEntity window)
			=> window.Do((e) => e.isPreparationInProcess = false)
			         .Do((e) => e.isPrepared = true);
	}
}