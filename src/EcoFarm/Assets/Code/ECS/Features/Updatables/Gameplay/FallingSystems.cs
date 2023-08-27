namespace EcoFarm
{
	public sealed class FallingSystems : FeatureBase
	{
		public FallingSystems(SystemsFactory factory)
			: base(nameof(FallingSystems), factory)
		{
			Add<MarkFallingSystem>();
			Add<FallingSystem>();
			Add<CheckFellUpSystem>();
			Add<DetachFromTreeSystem>();
			Add<MarkFellFruitAsPickableSystem>();
		}
	}
}