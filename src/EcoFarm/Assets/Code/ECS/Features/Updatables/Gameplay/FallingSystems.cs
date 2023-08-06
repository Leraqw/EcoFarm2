


namespace EcoFarm
{
	public sealed class FallingSystems : Feature
	{
		public FallingSystems(Contexts contexts)
			: base(nameof(FallingSystems))
		{
			Add(new MarkFallingSystem(contexts));
			Add(new FallingSystem(contexts));
			Add(new CheckFellUpSystem(contexts));
			Add(new DetachFromTreeSystem(contexts));
			Add(new MarkFellFruitAsPickableSystem(contexts));
		}
	}
}