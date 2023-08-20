using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class ProjectInstaller : MonoInstaller<ProjectInstaller>
	{
		[SerializeField] private GlobalEntitasAdapter _globalEntitasAdapter;

		public override void InstallBindings()
		{
			BindAdapter();
			BindContexts();

			Container.Bind<GlobalSystems>().AsSingle();
			Container.Bind<SystemsFactory>().AsSingle();
		}

		private void BindContexts()
		{
			var contexts = Contexts.sharedInstance;

			Container.Bind<Contexts>().FromInstance(contexts).AsSingle();
			Container.Bind<GameContext>().FromInstance(contexts.game).AsSingle();
			Container.Bind<InputContext>().FromInstance(contexts.input).AsSingle();
			Container.Bind<ServicesContext>().FromInstance(contexts.services).AsSingle();
			Container.Bind<PlayerContext>().FromInstance(contexts.player).AsSingle();
		}

		private void BindAdapter()
			=> Container.Bind<GlobalEntitasAdapter>()
			            .FromNewComponentOnNewPrefab(_globalEntitasAdapter)
			            .AsSingle()
			            .NonLazy();
	}
}