


namespace EcoFarm
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