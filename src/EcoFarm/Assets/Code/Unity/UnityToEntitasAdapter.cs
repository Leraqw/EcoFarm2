using Code.ECS.Features;
using UnityEngine;

namespace Code.Unity
{
	public class UnityToEntitasAdapter : MonoBehaviour
	{
		[SerializeField] private UnityDependencies _dependencies;

		private AllSystems _systems;

		private void Start()
		{
			_systems = new AllSystems(_dependencies);
			_systems.Initialize();
		}

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();
	}
}