using Code.ECS.Systems;

namespace Code.ECS.Features
{
	public sealed class AllSystems : Feature
	{
		private AllSystems(Contexts contexts)
			: base(nameof(AllSystems))
		{
			Add(new GreeterSystem(contexts));
		}

		public static AllSystems Create() => new(Contexts.sharedInstance);

		public void OnUpdate()
		{
			Execute();
			Cleanup();
		}
	}
}