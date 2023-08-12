namespace EcoFarm
{
	public sealed class InitializationSystems : Feature
	{
		public InitializationSystems(Contexts contexts)
			: base(nameof(InitializationSystems))
		{
			Add(new SpawnStorage(contexts));
			Add(new EmitPositionsForTreeSpawnSystem(contexts));
			Add(new CreateGoalsForLevelSystem(contexts));
			Add(new CreateLevelTimerSystem(contexts));

			Add(new InventoryInitializationSystems(contexts));

			Add(new SpawnTreeSystem(contexts));
			Add(new SpawnFruitSystem(contexts));
			Add(new SpawnBedsPlugsSystem(contexts));
			Add(new SpawnWarehouseSystem(contexts));
			Add(new SpawnSignsSystem(contexts));
			Add(new SpawnCraneSystem(contexts));
			Add(new SpawnBucketSystem(contexts));
		}
	}
}