using UnityEngine;
using Zenject;

namespace EcoFarm
{
    public class MainMenuInstaller : MonoInstaller<GameplayInstaller>
    {
        public override void InstallBindings()
        {
            BindAdapter();

            Container.Rebind<SystemsFactory>().AsSingle();
            Container.Bind<MainMenuContextSystems>().AsSingle();
        }

        private void BindAdapter()
            => Container.Bind<MainMenuEntitasAdapter>()
                .FromNewComponentOnNewGameObject()
                .AsSingle()
                .NonLazy();
    }
}