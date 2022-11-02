using Code.ECS.Systems.Common;
using Code.ECS.Systems.Product.Fruit;

namespace Code.ECS.Features
{
	public sealed class GameplaySystems : Feature
	{
		public GameplaySystems(Contexts contexts)
			: base(nameof(GameplaySystems))
		{
			Add(new InitializationSystems(contexts));

			Add(new CollectingSystems(contexts));

			Add(new ViewSystems(contexts));

			Add(new GrowingSystems(contexts));

			Add(new FallingSystems(contexts));

			Add(new DurationSystem(contexts));
			Add(new CheckDurationUpSystem(contexts));

			Add(new RemoveTargetsOnTimeUpSystem(contexts));
		}
	}
}