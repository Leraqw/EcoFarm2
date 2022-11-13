using Code.ECS.Features.Initialization;
using Code.Services.Interfaces;
using Code.Utils.Extensions.Entitas;

namespace Code.ECS.Features
{
	public sealed class AllSystems : Feature
	{
		public AllSystems(IAllServices services)
			: base(nameof(AllSystems))
		{
			var contexts = Contexts.sharedInstance;
			Add(new ServicesRegistrationSystems(contexts, services));

			Add(new GameplaySystems(contexts));

			Add(new GameEventSystems(contexts));
			Add(new GameCleanupSystems(contexts));
		}

		public void OnUpdate() => this.ExecuteAnd().Cleanup();
	}
}