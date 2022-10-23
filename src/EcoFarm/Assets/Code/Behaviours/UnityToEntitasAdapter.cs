using Code.ECS.Features;
using Code.Services.UnityImplementations;
using UnityEngine;

namespace Code.Behaviours
{
	public class UnityToEntitasAdapter : MonoBehaviour
	{
		private AllSystems _systems;

		private void Awake() => _systems = new AllSystems(Contexts.sharedInstance, new UnityAllResources());

		private void Start() => _systems.Initialize();

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();
	}
}