using Code.ECS.Features;
using UnityEngine;

namespace Code.Unity
{
	public class EntitasDirector : MonoBehaviour
	{
		private AllSystems _systems;

		private void Awake() => _systems = new AllSystems(Contexts.sharedInstance);

		private void Start() => _systems.Initialize();

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();
	}
}