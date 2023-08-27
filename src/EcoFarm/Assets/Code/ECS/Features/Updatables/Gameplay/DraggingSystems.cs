namespace EcoFarm
{
	public sealed class DraggingSystems : FeatureBase
	{
		public DraggingSystems(SystemsFactory factory)
			: base(nameof(DraggingSystems), factory)
		{
			Add<DraggingSystem>();
			Add<ReleaseAtDraggableSystem>();
			Add<ReturnDraggableToInitialSystem>();
		}
	}
}