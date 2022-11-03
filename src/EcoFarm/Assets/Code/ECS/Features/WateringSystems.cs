using Code.ECS.Systems.Watering.Bucket;
using Code.ECS.Systems.Watering.Crane;

namespace Code.ECS.Features
{
	public sealed class WateringSystems : Feature
	{
		public WateringSystems(Contexts contexts)
			: base(nameof(WateringSystems))
		{
			Add(new PourWaterSystem(contexts));
			Add(new WaterNearTreeSystem(contexts));
			Add(new ClickOnCraneSystem(contexts));
		}
	}
}