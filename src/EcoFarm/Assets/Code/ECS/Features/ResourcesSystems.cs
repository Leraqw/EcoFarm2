namespace Code
{
	public sealed class ResourcesSystems : Feature
	{
		public ResourcesSystems(Contexts contexts)
		{
			Add(new InitializeResourcesSystem(contexts));
			Add(new PostInitializeCraneResourceSystem(contexts));
			Add(new ConsumeUsedResourcesSystem(contexts));
			Add(new PermanentProduceResourceSystem(contexts));
			Add(new UseCraneSystem(contexts));
			Add(new OnResourceButtonClickSystem(contexts));
		}
	}
}