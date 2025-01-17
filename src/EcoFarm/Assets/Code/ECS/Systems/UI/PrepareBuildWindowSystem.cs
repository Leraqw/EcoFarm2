﻿using System.Collections.Generic;
using System.Linq;
using Entitas;
using Entitas.VisualDebugging.Unity;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class PrepareBuildWindowSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;
		private readonly GameEntity.Factory _gameEntityFactory;

		public PrepareBuildWindowSystem(Contexts contexts, IUiService uiService, GameEntity.Factory gameEntityFactory)
			: base(contexts.game)
		{
			_contexts = contexts;
			_uiService = uiService;
			_gameEntityFactory = gameEntityFactory;
		}

		private IEnumerable<Building> Buildings => _contexts.game.storage.Value.Buildings;

		private BuildView BuildViewPrefab => _uiService.BuildView;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(PreparationInProcess, BuildWindow));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Prepare);

		private void Prepare(GameEntity window)
			=> window.Do(CleanBuildingList)
			         .Do(FillBuildingsList)
			         .Do(EndPreparations);

		private static void CleanBuildingList(GameEntity window)
			=> window.GetAttachedEntities()
			         .Where((e) => e.hasView)
			         .Do((entities) => entities.ForEach((e) => e.isDestroy = true))
			         .Do((entities) => entities.ForEach((e) => e.view.Value.DestroyGameObject()));

		private void FillBuildingsList(GameEntity window)
			=> Buildings.ForEach((b) => BindBuildingButtonView(b, BuildViewPrefab, window));

		private void BindBuildingButtonView(Building building, Component prefab, GameEntity window)
			=> _gameEntityFactory.Create()
			                     .Do((e) => e.isUiElement = true)
			                     .Do((e) => e.AddUiParent(window.buildWindow.Value.ContentView))
			                     .Do((e) => e.AddBuilding(building))
			                     .Do((e) => e.AddViewPrefab(prefab.gameObject))
			                     .Do((e) => e.AddPosition(window.position.Value))
			                     .AttachTo(window);

		private static void EndPreparations(GameEntity window)
			=> window.Do((e) => e.isPreparationInProcess = false)
			         .Do((e) => e.isPrepared = true);
	}
}