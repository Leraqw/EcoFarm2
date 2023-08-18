using System;
using System.Collections.Generic;
using Entitas;
using Entitas.VisualDebugging.Unity;
using UnityEngine;
using static EcoFarm.Constants;
using static GameMatcher;
using static EcoFarm.Constants.SpriteHigh;

namespace EcoFarm
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

		private static IMatcher<GameEntity> Building => GameMatcher.Building;

		private WindowScroll Window => _contexts.services.uiService.Value.Windows.Build;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(UiElement, Bought, Building));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites)
		{
			entites.ForEach(Spawn);

			_contexts.game.CreateEntity()
			         .Do((e) => e.AttachTo(Window.Listener.Entity))
			         .Do((e) => e.AddTargetActivity(false))
				;
		}

		private void Spawn(GameEntity button) 
			=> _signs.ForEach((s) => Replace(s, button), @if: (s) => Fits(s, button));

		private bool Fits(GameEntity sign, GameEntity button)
			=> sign.isOccupied == false && sign.HasSamePosition(button);

		private void Replace(GameEntity sign, GameEntity button)
			=> sign
			   .Do((e) => e.AddBuilding(button.building.Value))
			   .Do((e) => e.ReplaceDebugName($"Building {e.building.Value.Title}"))
			   .Do(SetFactory, @if: BuildingIs<Factory>)
			   .Do(SetGenerator, @if: BuildingIs<Generator>)
			   .Do(DestroySign)
			   .Do(AddRelativeView)
			   .Do((e) => e.isOccupied = true)
			   .Do(AddConsumption, @if: (e) => e.hasFactory)
			   .Do(AddProduction, @if: (e) => e.hasGenerator);

		private void AddRelativeView(GameEntity entity)
			=> entity
			   .Do((e) => e.ReplaceViewPrefab(Resource.Prefab.Factory), @if: (e) => e.hasFactory)
			   .Do(RelativeGeneratorView, @if: (e) => e.hasGenerator);

		private void RelativeGeneratorView(GameEntity generator)
			=> generator
			   .Do(SetPrefab(Resource.Prefab.Windmill), @if: generator.GeneratorIs(WindmillName))
			   .Do(SetPrefab(Resource.Prefab.WaterCleaner), @if: generator.GeneratorIs(WaterCleanerName));

		private static Action<GameEntity> SetPrefab(GameObject prefab) => (e) => e.ReplaceViewPrefab(prefab);

		private void AddProduction(GameEntity entity)
			=> entity
			   .Do((e) => e.AddProduceResource(e.GetGeneratorResource().consumable.Value))
			   .Do((e) => e.AddEfficiencyCoefficient(e.generator.Value.EfficiencyCoefficient))
			   .Do(InitializeAsWindmill, @if: (e) => e.GeneratorIs(WindmillName))
			   .Do(InitializeAsWaterCleaner, @if: (e) => e.GeneratorIs(WaterCleanerName));

		private void InitializeAsWaterCleaner(GameEntity e)
		{
			e.isCleanerGenerator = true;
			e.AddSprite(_contexts.GetConfiguration().Resource.Sprite.WaterCleaner.Clean);
			e.AddSpriteHigh(Normal);
		}

		private void InitializeAsWindmill(GameEntity e)
		{
			e.isPermanentGenerator = true;
			e.AddDuration(1);
		}

		private void AddConsumption(GameEntity entity)
			=> entity
			   .Do((e) => e.AddConsumer(e.GetFactoryResource().consumable.Value))
			   .Do((e) => e.AddConsumptionCoefficient(e.factory.Value.ResourceConsumptionCoefficient));

		private static bool BuildingIs<T>(GameEntity entity) => entity.hasBuilding && entity.building.Value is T;

		private static void SetGenerator(GameEntity entity)
			=> entity
			   .Do((e) => e.AddGenerator((Generator)entity.building.Value))
			   .Do((e) => e.RemoveBuilding());

		private static void SetFactory(GameEntity entity)
			=> entity
			   .Do((e) => e.AddFactory((Factory)entity.building.Value))
			   .Do((e) => e.RemoveBuilding())
			   .Do((e) => e.AddSpriteHigh(1));

		private static void DestroySign(GameEntity entity)
			=> entity
			   .Do((e) => e.view.Value.DestroyGameObject())
			   .Do((e) => e.RemovePositionListener())
			   .Do((e) => e.RemoveView())
			   .Do((e) => e.isSign = false);
	}
}