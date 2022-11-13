using Code.ECS.Features.Initialization;
using Code.ECS.Features.Updatables;
using Code.ECS.Features.Updatables.Cleanup;
using Code.ECS.Features.Updatables.Gameplay;
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
			Add(new WateringSystems(contexts));
			Add(new DurationSystems(contexts));
			Add(new InventorySystems(contexts));
			
			// TODO: Add GameCycleSystems 
			Add(new GameOverSystem(contexts));
			
			// TODO: Add GameOverSystems
			Add(new DestroyAllGameEntitiesSystem(contexts));

			Add(new CleanupSystems(contexts));
		}
	}
}