namespace EcoFarm
{
	public sealed class ViewSystems : FeatureBase
	{
		public ViewSystems(SystemsFactory factory)
			: base(nameof(ViewSystems), factory)
		{
			Add<LoadViewForEntitySystem>();
			Add<BindViewsSystem>();
			Add<LoadRequiredSpriteSystem>();
		}
	}
}