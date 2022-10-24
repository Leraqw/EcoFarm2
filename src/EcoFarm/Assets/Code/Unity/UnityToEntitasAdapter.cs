using Code.ECS.Features;
using Code.Services.Interfaces;
using Code.Services.UnityImplementations;
using UnityEngine;

namespace Code.Unity
{
	public class UnityToEntitasAdapter : MonoBehaviour
	{
		[SerializeField] private UnityDependencies _dependencies;

		private AllSystems _systems;

		private void Start()
		{
			IAllServices resources = new UnityAllResources(_dependencies.SceneObjects);
			_systems = new AllSystems(resources);
			_systems.Initialize();
		}

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();
	}
}