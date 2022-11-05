using Code.ECS.Systems.View;

namespace Code.ECS.Features
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