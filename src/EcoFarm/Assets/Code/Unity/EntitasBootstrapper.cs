using Code.ECS.Features;
using UnityEngine;

namespace Code.Unity
{
	public class EntitasBootstrapper : MonoBehaviour
	{
		private AllSystems _systems;

		private void Start()
		{
			var contexts = Contexts.sharedInstance;

			_systems = new AllSystems(contexts);

			_systems.Initialize();
		}

		private void Update() => _systems.Tick();

		private void OnDestroy() => _systems.TearDown();
	}
}