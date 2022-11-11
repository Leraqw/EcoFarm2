using Code.ECS.Features.Initialization;
using Code.ECS.Features.Updatables;
using Code.ECS.Features.Updatables.Cleanup;
using Code.ECS.Features.Updatables.Gameplay;

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

			Add(new CleanupSystems(contexts));
		}
	}
}