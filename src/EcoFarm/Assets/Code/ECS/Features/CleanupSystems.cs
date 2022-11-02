using Code.ECS.Systems.Product.Fruit;

namespace Code.ECS.Features
{
	public sealed class CleanupSystems : Feature
	{
		public CleanupSystems(Contexts contexts)
			: base(nameof(CleanupSystems))
		{
			Add(new RemoveTargetsOnTimeUpSystem(contexts));
		}
	}
}