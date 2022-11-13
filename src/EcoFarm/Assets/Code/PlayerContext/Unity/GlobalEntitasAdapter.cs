using Code.PlayerContext.Features;
using Code.Services.Interfaces;
using Code.Services.UnityImplementations;
using UnityEngine;

namespace Code.PlayerContext.Unity
{
	public class GlobalEntitasAdapter : MonoBehaviour
	{
		private PlayerSystems _systems;

		private void Start()
		{
			DontDestroyOnLoad(gameObject);
			
			IGlobalServices resources = new UnityGlobalServices();

			_systems = new PlayerSystems(resources);
			_systems.Initialize();
		}

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();

	}
}