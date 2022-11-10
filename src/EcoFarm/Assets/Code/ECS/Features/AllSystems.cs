using Code.ECS.Features.Initialization;
using Code.Services.Interfaces;
using Code.Utils.Extensions;

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

			Add(new GameCleanupSystems(contexts));
			Add(new GameEventSystems(contexts));
		}

		public void OnUpdate() => this.Do(Execute).Do(Cleanup);

		private static void Execute(AllSystems @this) => @this.Execute();

		private static void Cleanup(AllSystems @this) => @this.Cleanup();
	}
}