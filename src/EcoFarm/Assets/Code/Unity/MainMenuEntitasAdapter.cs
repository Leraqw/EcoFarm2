using UnityEngine;

namespace EcoFarm
{
    public class MainMenuEntitasAdapter : MonoBehaviour
    {
        [SerializeField] private UnityMainMenuDependencies _dependencies;

        private MainMenuSystems _systems;

        private void Start()
        {
            _systems = new MainMenuSystems(_dependencies);
            _systems.Initialize();
        }

        private void Update() => _systems.OnUpdate();

        private void OnDestroy() => _systems.TearDown();
    }
}