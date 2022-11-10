using Code.ECS.Systems.Common.DragAndDrop;
using Code.ECS.Systems.Input;

namespace Code.ECS.Features.Updatables.Gameplay
{
	public sealed class DraggingSystems : Feature
	{
		public DraggingSystems(Contexts contexts)
			: base(nameof(DraggingSystems))
		{
			Add(new DraggingSystem(contexts));
			Add(new ReleaseAtDraggableSystem(contexts));
			Add(new ReturnDraggableToInitialSystem(contexts));
		}
	}
}