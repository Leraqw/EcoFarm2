using Code.ECS.Systems.Common.DragAndDrop;

namespace Code.ECS.Features
{
	public sealed class DraggingSystems : Feature
	{
		public DraggingSystems(Contexts contexts)
			: base(nameof(DraggingSystems))
		{
			Add(new DraggingSystem(contexts));
		}
	}
}