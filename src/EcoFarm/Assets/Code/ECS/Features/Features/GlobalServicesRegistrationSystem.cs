using Entitas;

namespace EcoFarm
{
	public sealed class GlobalServicesRegistrationSystem : IInitializeSystem
	{
		private readonly ServicesContext _context;

		public GlobalServicesRegistrationSystem(Contexts contexts) => _context = contexts.services;

		public void Initialize()
		{
			_context.ReplaceDataProvider(new SerializableObjectDataProvider());
			_context.ReplaceResourcesService(new UnityResourceService());
			_context.ReplaceCameraService(new UnityCameraService());
			_context.ReplaceInputService(new UnityInputService());
			_context.ReplaceSceneTransferService(new UnitySceneTransferService());
			
			_context.ReplacePrefabProvider(new PrefabDataProvider());
		}
	}
}