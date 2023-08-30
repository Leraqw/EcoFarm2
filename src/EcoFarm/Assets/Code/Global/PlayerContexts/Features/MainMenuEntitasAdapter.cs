using UnityEngine;
using Zenject;

namespace EcoFarm
{
    public class MainMenuEntitasAdapter : MonoBehaviour
    {
        private MainMenuContextSystems _contextSystems;

        [Inject]
        public void Construct(MainMenuContextSystems contextSystems) => _contextSystems = contextSystems;

        private void Start() => _contextSystems.Initialize();

        private void Update()
        {
            _contextSystems.Execute();
            _contextSystems.Cleanup();
        }

        private void OnDestroy() => _contextSystems.TearDown();
    }
}