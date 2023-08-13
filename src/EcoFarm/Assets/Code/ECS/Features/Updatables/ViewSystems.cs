

namespace EcoFarm
{
	public sealed class ViewSystems : Feature
	{
		public ViewSystems(Contexts contexts)
			: base(nameof(ViewSystems))
		{
			Add(new LoadViewForEntitySystem(contexts));
			Add(new BindViewsSystem(contexts));
			Add(new LoadRequiredSpriteSystem(contexts));
		}
	}
}