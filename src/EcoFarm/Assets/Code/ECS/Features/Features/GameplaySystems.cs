namespace EcoFarm
{
	public sealed class GameplaySystems : FeatureBase
	{
		public GameplaySystems(SystemsFactory factory)
			: base(nameof(GameplaySystems), factory)
		{
			Add<InitializationSystems>();
			Add<UiSystems>();

			Add<InputSystems>();
			Add<CollectingSystems>();
			Add<DraggingSystems>();
			Add<ViewSystems>();
			Add<GrowingSystems>();
			Add<FallingSystems>();
			Add<ResourcesSystems>();
			Add<WateringSystems>();
			Add<DurationSystems>();
			Add<InventorySystems>();

			// TODO: Add BuildingSystems
			Add<ClickOnBuildItemSystem>();
			Add<SpawnBoughtBuildingSystem>();
			Add<ClickOnFactorySystem>();
			Add<PerformProductsRequestSystem>();
			Add<FactoryWorkingStateSystem>();
			Add<ProduceProductSystem>();
			Add<StartCleaningPollutionSystem>();
			Add<ReplaceSpriteWhileWorkingSystem>();
			Add<GenerateCleanedResourceSystem>();

			// Dancing
			Add<DanceWhileWorkingSystem>();
			Add<ResetNormalScaleSystem>();

			// Rotating
			Add<RotateSpinnersSystem>();

			// TODO: Add GameCycleSystems 
			Add<ObserveGoalCompletionSystem>();
			Add<GameOverSystem>();

			// TODO: Add GameOverSystems
			Add<DestroyAllGameEntitiesSystem>();

			Add<CleanupSystems>();
		}
	}
}