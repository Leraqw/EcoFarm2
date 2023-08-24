using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class GameplayInstaller : MonoInstaller<GameplayInstaller>
	{
		[SerializeField] private UnityDependencies _dependencies;

		public override void InstallBindings()
		{
			BindAdapter();

			Container.Rebind<SystemsFactory>().AsSingle();
			Container.BindInstance(_dependencies.EntityBehaviours).AsSingle();

			Container.Bind<GameContextSystems>().AsSingle();

			BindServices();

			Container.Bind<ServicesSingleton>().AsSingle().NonLazy();
		}

		private void BindAdapter()
			=> Container.Bind<GameplayEntitasAdapter>()
			            .FromNewComponentOnNewGameObject()
			            .AsSingle()
			            .NonLazy();

		private void BindServices()
		{
			Container.BindInstance<ISpawnPointsService>(_dependencies.SpawnPoints).AsSingle();
			Container.BindInstance<IConfigurationService>(_dependencies.UnityConfiguration).AsSingle();
			Container.BindInstance<IUiService>(_dependencies.UiService).AsSingle();
		}
	}
}