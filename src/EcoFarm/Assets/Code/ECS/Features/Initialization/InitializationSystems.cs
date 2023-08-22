namespace EcoFarm
{
	public sealed class InitializationSystems : FeatureBase
	{
		public InitializationSystems(SystemsFactory factory)
			: base(nameof(InitializationSystems), factory)
		{
			Add<SpawnStorageSystem>();
			Add<EmitPositionsForTreeSpawnSystem>();
			Add<CreateGoalsForLevelSystem>();
			Add<CreateLevelTimerSystem>();

			Add<InventoryInitializationSystems>();

			Add<SpawnTreeSystem>();
			Add<SpawnFruitSystem>();
			Add<SpawnBedsPlugsSystem>();
			Add<SpawnWarehouseSystem>();
			Add<SpawnSignsSystem>();
			Add<SpawnCraneSystem>();
			Add<SpawnBucketSystem>();
		}
	}
}