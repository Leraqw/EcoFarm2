using UnityEngine;

namespace Code
{
	public class GlobalEntitasAdapter : MonoBehaviour
	{
		private GlobalSystems _systems;

		private void Start()
		{
			DontDestroyOnLoad(gameObject);

			IGlobalServices resources = new UnityGlobalServices();

			_systems = new GlobalSystems(resources);
			_systems.Initialize();
		}

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();
	}
}