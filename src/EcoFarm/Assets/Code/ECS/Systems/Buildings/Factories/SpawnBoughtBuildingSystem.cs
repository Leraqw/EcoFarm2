using System.Collections.Generic;
using System.Linq;
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

		// TODO: Remove Linq
		private FactoryBuilding FirstFactory => (FactoryBuilding)_contexts.game.storage.Value.Buildings.First();

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(UiElement, Bought, GameMatcher.Building));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Spawn);

		private void Spawn(GameEntity button) => _signs.ForEach(Replace, @if: (s) => Fits(s, button));

		private bool Fits(GameEntity sign, GameEntity button)
			=> sign.isOccupied == false && sign.HasSamePosition(button);

		private void Replace(GameEntity sign)
			=> sign
			   .Do((e) => e.ReplaceDebugName("Building Factory"))
			   .Do((e) => e.view.Value.DestroyGameObject())
			   .Do((e) => e.RemovePositionListener())
			   .Do((e) => e.RemoveView())
			   .Do((e) => e.ReplaceViewPrefab(Resource.Prefab.Factory))
			   .Do((e) => e.isOccupied = true)
			   .Do((e) => e.AddConsumer(_contexts.game.energyResourceEntity.consumable))
			   .Do((e) => e.AddConsumptionCoefficient(FirstFactory.ResourceConsumptionCoefficient));

		private IResourceConfig Resource => _contexts.services.configurationService.Value.Resource;
	}
}