using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class ProjectInstaller : MonoInstaller<ProjectInstaller>
	{
		[SerializeField] private UnityConfiguration _configuration;

		public override void InstallBindings()
		{
			BindAdapter();
			BindContexts();

			Container.Bind<GlobalSystems>().AsSingle();
			Container.Bind<SystemsFactory>().AsSingle();

			BindServices();
			BindFactories();

			BindTools();
		}

		private void BindAdapter()
			=> Container.Bind<GlobalEntitasAdapter>()
			            .FromNewComponentOnNewGameObject()
			            .AsSingle()
			            .NonLazy();

		private void BindContexts()
		{
			var contexts = Contexts.sharedInstance;

			Container.BindInstance(contexts).AsSingle();
			Container.BindInstance(contexts.game).AsSingle();
			Container.BindInstance(contexts.input).AsSingle();
			Container.BindInstance(contexts.services).AsSingle();
			Container.BindInstance(contexts.player).AsSingle();
		}

		private void BindServices()
		{
			Container.Bind<IDataProviderService>().To<SerializableObjectDataProvider>().AsSingle();
			Container.Bind<IResourcesService>().To<UnityResourceService>().AsSingle();
			Container.Bind<ICameraService>().To<UnityCameraService>().AsSingle();
			Container.Bind<IInputService>().To<UnityInputService>().AsSingle();
			Container.Bind<ISceneTransferService>().To<UnitySceneTransferService>().AsSingle();

			Container.BindInstance<IConfigurationService>(_configuration).AsSingle();
		}

		private void BindFactories()
		{
			Container.BindFactory<GameEntity, GameEntity.Factory>().AsSingle();
			Container.BindFactory<WateringView, WateringView.Factory>().AsSingle();
		}

		private void BindTools()
		{
			Container.Bind<ServicesMediator>().ToSelf().AsSingle();
			Container.Bind<Injector>().ToSelf().AsSingle();
		}
	}
}