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
        }

		private void BindAdapter()
			=> Container.Bind<GameplayEntitasAdapter>()
			            .FromNewComponentOnNewGameObject()
			            .AsSingle()
			            .NonLazy();

		private void BindServices()
		{
			Container.BindInstance<ISpawnPointsService>(_dependencies.SpawnPoints).AsSingle();
			Container.BindInstance<IUiService>(_dependencies.UiService).AsSingle();
		}
	}
}