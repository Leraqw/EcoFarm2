using Code.ECS.Systems.EcoResources;
using Code.ECS.Systems.EcoResources.Water;

namespace Code.ECS.Features
{
	public sealed class ResourcesSystems : Feature
	{
		public ResourcesSystems(Contexts contexts)
		{
			Add(new InitializeResourcesSystem(contexts));
			Add(new PostInitializeCraneResourceSystem(contexts));
			Add(new ConsumeUsedResourcesSystem(contexts));
			Add(new ProduceResourceSystem(contexts));
			Add(new UseCraneSystem(contexts));
			Add(new OnResourceButtonClickSystem(contexts));
		}
	}
}