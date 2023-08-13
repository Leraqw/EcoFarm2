
using UnityEngine;

namespace EcoFarm
{
	public class GameplayEntitasAdapter : MonoBehaviour
	{
		[SerializeField] private UnityDependencies _dependencies;

		private GameContextSystems _systems;

		private void Start()
		{
			_systems = new GameContextSystems(_dependencies);
			_systems.Initialize();
		}

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();
	}
}