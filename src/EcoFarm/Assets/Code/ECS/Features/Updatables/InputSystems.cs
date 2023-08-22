namespace EcoFarm
{
	public sealed class InputSystems : FeatureBase
	{
		public InputSystems(SystemsFactory factory)
			: base(nameof(InputSystems), factory)
		{
			Add<ClickAtPickableSystem>();
			Add<ClickAtDraggableSystem>();

			Add<ClickAtSignSystem>();
		}
	}
}