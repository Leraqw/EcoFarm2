using Zenject;

namespace EcoFarm
{
	public class LevelsListInstaller : MonoInstaller<LevelsListInstaller>
	{
		public override void InstallBindings()
		{
			BindAdapter();

			Container.Rebind<SystemsFactory>().AsSingle();
			Container.Bind<LevelChoiceSystems>().AsSingle();
		}

		private void BindAdapter()
			=> Container.Bind<LevelChoiceToEntitasAdapter>()
			            .FromNewComponentOnNewGameObject()
			            .AsSingle()
			            .NonLazy();
	}
}