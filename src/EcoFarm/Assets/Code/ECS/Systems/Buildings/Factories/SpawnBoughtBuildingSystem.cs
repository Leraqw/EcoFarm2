﻿using System.Collections.Generic;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using EcoFarmDataModule;
using Entitas;
using Entitas.VisualDebugging.Unity;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Factories
{
	public sealed class SpawnBoughtBuildingSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		private readonly IGroup<GameEntity> _signs;

		public SpawnBoughtBuildingSystem(Contexts contexts)
			: base(contexts.game)
		{
			_contexts = contexts;
			_signs = contexts.game.GetGroup(Sign);
		}

		private IResourceConfig Resource => _contexts.services.configurationService.Value.Resource;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(UiElement, Bought, GameMatcher.Building));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Spawn);

		private void Spawn(GameEntity button) => _signs.ForEach((s) => Replace(s, button), @if: (s) => Fits(s, button));

		private bool Fits(GameEntity sign, GameEntity button)
			=> sign.isOccupied == false && sign.HasSamePosition(button);

		private void Replace(GameEntity sign, GameEntity button)
			=> sign
			   .Do((e) => e.ReplaceDebugName("Building Factory"))
			   .Do((e) => e.AddBuilding(button.building))
			   .Do(SetFactory, @if: BuildingIs<FactoryBuilding>)
			   .Do(SetGenerator, @if: BuildingIs<Generator>)
			   .Do(DestroySign)
			   .Do(AddRelativeView)
			   .Do((e) => e.isOccupied = true)
			   .Do(AddConsumption, @if: (e) => e.hasFactory)
			   .Do(AddProduction, @if: (e) => e.hasGenerator)
		/**/;

		private void AddRelativeView(GameEntity entity)
			=> entity
			   .Do((e) => e.ReplaceViewPrefab(Resource.Prefab.Factory), @if: (e) => e.hasFactory)
			   .Do((e) => e.ReplaceViewPrefab(Resource.Prefab.Windmill), @if: (e) => e.hasGenerator)
		/**/;

		private void AddProduction(GameEntity entity)
			=> entity
			   .Do((e) => e.AddResource(_contexts.game.energyResourceEntity.consumable))
			   .Do((e) => e.AddEfficiencyCoefficient(e.generator.Value.EfficiencyCoefficient))
		/**/;

		private void AddConsumption(GameEntity entity)
			=> entity
			   .Do((e) => e.AddConsumer(_contexts.game.energyResourceEntity.consumable))
			   .Do((e) => e.AddConsumptionCoefficient(e.factory.Value.ResourceConsumptionCoefficient))
		/**/;

		private static bool BuildingIs<T>(GameEntity entity) => entity.hasBuilding && entity.building.Value is T;

		private static void SetGenerator(GameEntity entity)
			=> entity
			   .Do((e) => e.AddGenerator((Generator)entity.building))
			   .Do((e) => e.RemoveBuilding())
		/**/;

		private static void SetFactory(GameEntity entity)
			=> entity
			   .Do((e) => e.AddFactory((FactoryBuilding)entity.building))
			   .Do((e) => e.RemoveBuilding())
		/**/;

		private static void DestroySign(GameEntity entity)
			=> entity
			   .Do((e) => e.view.Value.DestroyGameObject())
			   .Do((e) => e.RemovePositionListener())
			   .Do((e) => e.RemoveView())
			   .Do((e) => e.isSign = false)
		/**/;
	}
}