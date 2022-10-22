using Code.ECS.Features;
using UnityEngine;

namespace Code.Unity
{
	public class EntitasBootstrapper : MonoBehaviour
	{
		private AllSystems _systems;

		private void Awake()
		{
			var contexts = Contexts.sharedInstance;
			_systems = new AllSystems(contexts);
		}

		private void Start() => _systems.Initialize();

		private void Update() => _systems.Tick();

		private void OnDestroy() => _systems.TearDown();
	}
}