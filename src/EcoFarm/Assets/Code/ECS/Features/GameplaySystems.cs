using Code.ECS.Features.Initialization;
using Code.ECS.Features.Updatables;
using Code.ECS.Features.Updatables.Cleanup;
using Code.ECS.Features.Updatables.Gameplay;
using Code.ECS.Systems.Buildings;
using Code.ECS.Systems.Buildings.Factories;
using Code.ECS.Systems.Goals;
using Code.ECS.Systems.Level;
using Code.ECS.Systems.TearDown;

namespace Code.ECS.Features
{
	public sealed class GameplaySystems : Feature
	{
		public GameplaySystems(Contexts contexts)
			: base(nameof(GameplaySystems))
		{
			Add(new InitializationSystems(contexts));
			Add(new UiSystems(contexts));

			Add(new InputSystems(contexts));
			Add(new CollectingSystems(contexts));
			Add(new DraggingSystems(contexts));
			Add(new ViewSystems(contexts));
			Add(new GrowingSystems(contexts));
			Add(new FallingSystems(contexts));
			Add(new ResourcesSystems(contexts));
			Add(new WateringSystems(contexts));
			Add(new DurationSystems(contexts));
			Add(new InventorySystems(contexts));

			// TODO: Add BuildingSystems
			Add(new ClickOnBuildItemSystem(contexts));
			Add(new SpawnBoughtBuildingSystem(contexts));
			Add(new ClickOnFactorySystem(contexts));
			Add(new PerformProductsRequestSystem(contexts));
			Add(new ProduceProductSystem(contexts));

			// TODO: Add GameCycleSystems 
			Add(new ObserveGoalCompletionSystem(contexts));
			Add(new GameOverSystem(contexts));

			// TODO: Add GameOverSystems
			Add(new DestroyAllGameEntitiesSystem(contexts));

			Add(new CleanupSystems(contexts));
		}
	}
}