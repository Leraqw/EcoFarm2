namespace EcoFarm
{
	public sealed class ResourcesSystems : FeatureBase
	{
		public ResourcesSystems(SystemsFactory factory)
			: base(nameof(ResourcesSystems), factory)
		{
			Add<InitializeResourcesSystem>();
			Add<PostInitializeCraneResourceSystem>();
			Add<ConsumeUsedResourcesSystem>();
			Add<PermanentProduceResourceSystem>();
			Add<UseCraneSystem>();
			Add<OnResourceButtonClickSystem>();
		}
	}
}