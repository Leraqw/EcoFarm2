using Code.ECS.Systems.Watering.Crane;

namespace Code.ECS.Features
{
	public sealed class GameplaySystems : Feature
	{
		public GameplaySystems(Contexts contexts)
			: base(nameof(GameplaySystems))
		{
			Add(new InitializationSystems(contexts));

			Add(new InputSystems(contexts));
			Add(new CollectingSystems(contexts));
			Add(new DraggingSystems(contexts));
			Add(new ViewSystems(contexts));
			Add(new GrowingSystems(contexts));
			Add(new FallingSystems(contexts));
			
			// TODO: Add Watering systems
			Add(new ClickOnCraneSystem(contexts));
			
			Add(new DurationSystems(contexts));

			Add(new CleanupSystems(contexts));
		}
	}
}