using Zenject;

namespace EcoFarm
{
	public class BootstrapInstaller : MonoInstaller, IInitializable
	{
		public override void InstallBindings()
		{
			Container.Bind<IInitializable>().FromInstance(this).AsSingle();
		}

		void IInitializable.Initialize()
		{
			Container.Resolve<ISceneTransferService>().ToMainMenuScene();
		}
	}
}