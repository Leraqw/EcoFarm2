using Code.PlayerContext.Features;
using UnityEngine;

namespace Code.PlayerContext.Unity
{
	public class GlobalEntitasAdapter : MonoBehaviour
	{
		private PlayerSystems _systems;

		private void Start()
		{
			DontDestroyOnLoad(gameObject);
			
			_systems = new PlayerSystems();
			_systems.Initialize();
		}

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();

	}
}