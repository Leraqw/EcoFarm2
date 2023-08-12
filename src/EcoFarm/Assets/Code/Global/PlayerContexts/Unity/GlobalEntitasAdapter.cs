using UnityEngine;

namespace EcoFarm
{
	public class GlobalEntitasAdapter : MonoBehaviour
	{
		private GlobalSystems _systems;

		private void Start()
		{
			DontDestroyOnLoad(gameObject);

			_systems = new GlobalSystems();
			_systems.Initialize();
		}

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();
	}
}