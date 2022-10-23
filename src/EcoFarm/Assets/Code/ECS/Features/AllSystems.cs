using Code.ECS.Systems;
using Code.Services.Interfaces;

namespace Code.ECS.Features
{
	public sealed class AllSystems : Feature
	{
		public AllSystems(Contexts contexts, IAllServices services)
			: base(nameof(AllSystems))
		{
			Add(new ServicesRegistrationSystems(contexts, services));

			Add(new SpawnTreeSystem(contexts));
		}

		public void OnUpdate()
		{
			Execute();
			Cleanup();
		}
	}
}