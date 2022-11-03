using Code.ECS.Systems.Common.DragAndDrop;
using Code.ECS.Systems.Input;
using Code.ECS.Systems.Watering.Bucket;

namespace Code.ECS.Features
{
	public sealed class DraggingSystems : Feature
	{
		public DraggingSystems(Contexts contexts)
			: base(nameof(DraggingSystems))
		{
			Add(new DraggingSystem(contexts));
			Add(new ReleaseAtDraggableSystem(contexts));
			Add(new ReturnReleasedDraggableToInitialPositionSystem(contexts));
			
			// Watering
			Add(new WaterNearTreeSystem(contexts));
			Add(new PourWaterSystem(contexts));
		}
	}
}