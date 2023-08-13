


namespace EcoFarm
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