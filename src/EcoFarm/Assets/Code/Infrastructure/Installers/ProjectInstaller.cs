using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class ProjectInstaller : MonoInstaller<ProjectInstaller>, IInitializable
	{
		[SerializeField] private UnityConfiguration _configuration;

		public override void InstallBindings()
		{
			Container.Bind<IInitializable>().FromInstance(this).AsSingle();
			
			BindEntitas();
			BindServices();
			BindFactories();
			BindTools();
		}

		void IInitializable.Initialize()
		{
			Container.Resolve<ISceneTransferService>().ToBootstrapScene();
		}

		private void BindEntitas()
		{
			BindAdapter();
			Container.Bind<GlobalSystems>().AsSingle();
			BindContexts();
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
			Container.Bind<SystemsFactory>().AsSingle();

			Container.BindFactory<GameEntity, GameEntity.Factory>().AsSingle();
			Container.BindFactory<PlayerEntity, PlayerEntity.Factory>().AsSingle();

			Container.BindFactory<WateringView, WateringView.Factory>().AsSingle();
		}

		private void BindTools()
		{
			Container.Bind<ServicesMediator>().ToSelf().AsSingle();
			Container.Bind<Injector>().ToSelf().AsSingle();
		}
	}
}