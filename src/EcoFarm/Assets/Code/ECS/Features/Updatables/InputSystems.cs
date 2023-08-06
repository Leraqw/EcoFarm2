

namespace EcoFarm
{
	public sealed class InputSystems : Feature
	{
		public InputSystems(Contexts contexts)
			: base(nameof(InputSystems))
		{
			Add(new ClickAtPickableSystem(contexts));
			Add(new ClickAtDraggableSystem(contexts));

			Add(new ClickAtSignSystem(contexts));
		}
	}
}