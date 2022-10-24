using Code.ECS.Systems;
using Code.ECS.Systems.View;
using Code.Services.Interfaces;

namespace Code.ECS.Features
{
	public sealed class AllSystems : Feature
	{
		public AllSystems(IAllServices services)
			: base(nameof(AllSystems))
		{
			var contexts = Contexts.sharedInstance;
			Add(new ServicesRegistrationSystems(contexts, services));

			Add(new SpawnTreesSystem(contexts));
			Add(new LoadViewForEntitySystem(contexts));
		}

		public void OnUpdate()
		{
			Execute();
			Cleanup();
		}
	}
}