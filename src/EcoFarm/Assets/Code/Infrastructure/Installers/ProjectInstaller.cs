using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class ProjectInstaller : MonoInstaller<ProjectInstaller>
	{
		public override void InstallBindings()
		{
			BindAdapter();
			BindContexts();

			Container.Bind<GlobalSystems>().AsSingle();
			Container.Bind<SystemsFactory>().AsSingle();

			BindServices();
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
			Container.BindInstance<IDataProviderService>(new SerializableObjectDataProvider()).AsSingle();
			Container.BindInstance<IResourcesService>(new UnityResourceService()).AsSingle();
			Container.BindInstance<ICameraService>(new UnityCameraService()).AsSingle();
			Container.BindInstance<IInputService>(new UnityInputService()).AsSingle();
			Container.BindInstance<ISceneTransferService>(new UnitySceneTransferService()).AsSingle();
		}
	}
}