using Zenject;

namespace EcoFarm
{
	public sealed class GameContextSystems : FeatureBase
	{
		[Inject]
		public GameContextSystems(SystemsFactory factory)
			: base(nameof(GameContextSystems), factory)
		{
			Add<GameplayServicesRegistrationSystem>();

			Add<InitializeSceneBehavioursSystems>();
			Add<GameplaySystems>();

			Add<GameEventSystems>();
			Add<GameCleanupSystems>();
			
			Add<DestroyAllGameEntitiesSystem>();
		}
	}
}