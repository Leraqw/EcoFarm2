namespace Code
{
	public sealed class GameplaySystems : Feature
	{
		public GameplaySystems(Contexts contexts)
			: base(nameof(GameplaySystems))
		{
			Add(new InitializationSystems(contexts));
			Add(new UiSystems(contexts));

			Add(new InputSystems(contexts));
			Add(new CollectingSystems(contexts));
			Add(new DraggingSystems(contexts));
			Add(new ViewSystems(contexts));
			Add(new GrowingSystems(contexts));
			Add(new FallingSystems(contexts));
			Add(new ResourcesSystems(contexts));
			Add(new WateringSystems(contexts));
			Add(new DurationSystems(contexts));
			Add(new InventorySystems(contexts));

			// TODO: Add BuildingSystems
			Add(new ClickOnBuildItemSystem(contexts));
			Add(new SpawnBoughtBuildingSystem(contexts));
			Add(new ClickOnFactorySystem(contexts));
			Add(new PerformProductsRequestSystem(contexts));
			Add(new FactoryWorkingStateSystem(contexts));
			Add(new ProduceProductSystem(contexts));
			Add(new StartCleaningPollutionSystem(contexts));
			Add(new ReplaceSpriteWhileWorkingSystem(contexts));
			Add(new GenerateCleanedResourceSystem(contexts));

			// Dancing
			Add(new DanceWhileWorkingSystem(contexts));
			Add(new ResetNormalScaleSystem(contexts));

			// Rotating
			Add(new RotateSpinnersSystem(contexts));

			// TODO: Add GameCycleSystems 
			Add(new ObserveGoalCompletionSystem(contexts));
			Add(new GameOverSystem(contexts));

			// TODO: Add GameOverSystems
			Add(new DestroyAllGameEntitiesSystem(contexts));

			Add(new CleanupSystems(contexts));
		}
	}
}