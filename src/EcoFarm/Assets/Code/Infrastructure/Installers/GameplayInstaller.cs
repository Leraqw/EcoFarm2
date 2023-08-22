using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class GameplayInstaller : MonoInstaller<GameplayInstaller>
	{
		[SerializeField] private UnityDependencies _unityDependencies;

		public override void InstallBindings()
		{
			BindAdapter();

			Container.Rebind<SystemsFactory>().AsSingle();
			Container.BindInstance(_unityDependencies).AsSingle();
			Container.BindInstance(_unityDependencies.EntityBehaviours).AsSingle();

			Container.Bind<GameContextSystems>().AsSingle();
		}

		private void BindAdapter()
			=> Container.Bind<GameplayEntitasAdapter>()
			            .FromNewComponentOnNewGameObject()
			            .AsSingle()
			            .NonLazy();
	}
}