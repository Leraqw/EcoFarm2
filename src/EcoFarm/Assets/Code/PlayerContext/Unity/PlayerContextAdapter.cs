using UnityEngine;

namespace Code.PlayerContext.Unity
{
	public class PlayerContextAdapter : MonoBehaviour
	{
		private PlayerSystems _systems;

		private void Start()
		{
			_systems = new PlayerSystems();
			_systems.Initialize();
		}

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();

	}
}