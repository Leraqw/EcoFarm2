using Code.ECS.Features.Features;
using Code.Unity;
using Code.Utils.Extensions.Entitas;

namespace Code.ECS.Features
{
	public sealed class GameContextSystems : Feature
	{
		public GameContextSystems(UnityDependencies dependencies)
			: base(nameof(GameContextSystems))
		{
			var contexts = Contexts.sharedInstance;
			Add(new GameplayServicesRegistrationSystems(contexts, dependencies));

			Add(new GameplaySystems(contexts));

			Add(new GameEventSystems(contexts));
			Add(new GameCleanupSystems(contexts));
		}

		public void OnUpdate() => this.ExecuteAnd().Cleanup();
	}
}