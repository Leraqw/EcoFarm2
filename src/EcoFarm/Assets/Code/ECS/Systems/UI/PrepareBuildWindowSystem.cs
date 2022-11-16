using System.Collections.Generic;
using Code.ECS.Systems.Watering.Bucket;
using Code.Unity.Containers;
using Code.Utils.Extensions;
using EcoFarmDataModule;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.UI
{
	public sealed class PrepareBuildWindowSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public PrepareBuildWindowSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.AllOf(GameMatcher.PreparationInProcess, GameMatcher.SellWindow));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Prepare);

		private void Prepare(GameEntity window)
		{
			var buildView = _contexts.services.uiService.Value.BuildViewContainer;
			var buildings = _contexts.game.storage.Value.Buildings;

			buildings.ForEach((b) => Prepare(b, buildView, window));

			EndPreparation(window);
		}

		private void Prepare(Building building, BuildViewContainer buildViewContainerPrefab, GameEntity window)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.isUiElement = true)
			            .Do((e) => e.AddUiParent(window.buildWindow.Value.ContentView))
			            .Do((e) => e.AddBuilding(building))
			            .Do((e) => e.AddViewPrefab(buildViewContainerPrefab.gameObject));

		private static void EndPreparation(GameEntity window)
			=> window
			   .Do((e) => e.isPreparationInProcess = false)
			   .Do((e) => e.isPrepared = true);
	}
}