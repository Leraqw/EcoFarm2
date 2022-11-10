using Code.ECS.Systems.Product.Fruit.Cooldown;
using Code.ECS.Systems.Product.Fruit.Growing;

namespace Code.ECS.Features.Updatables.Gameplay
{
	public sealed class GrowingSystems : Feature
	{
		public GrowingSystems(Contexts contexts)
			: base(nameof(GrowingSystems))
		{
			Add(new WaitBeforeGrowingSystem(contexts));
			Add(new GrowingSystem(contexts));
			Add(new WaitAfterGrowingSystem(contexts));
			Add(new CheckGrowthUpSystem(contexts));
		}
	}
}