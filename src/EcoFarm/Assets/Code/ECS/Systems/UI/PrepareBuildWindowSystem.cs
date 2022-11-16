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
			var buildView = _contexts.services.uiService.Value.BuildView;
			var buildings = _contexts.game.storage.Value.Buildings;

			buildings.ForEach((b) => Prepare(b, buildView, window));

			EndPreparation(window);
		}

		private void Prepare(DevelopmentObject building, BuildView buildViewPrefab, GameEntity window)
		{
			var parent = window.buildWindow.Value.ContentView.transform;

			var buildView = Object.Instantiate(buildViewPrefab, parent);
			buildView.TitleTextMesh.text = building.Title;
			buildView.DescriptionTextMesh.text = building.Description;
			buildView.PriceTextMesh.text = building.Price.ToString();
			buildView.Image.sprite = _contexts.GetConfiguration().Resource.SpriteSheet.Buildings[building.Title];
		}

		private static void EndPreparation(GameEntity window)
			=> window
			   .Do((e) => e.isPreparationInProcess = false)
			   .Do((e) => e.isPrepared = true);
	}
}