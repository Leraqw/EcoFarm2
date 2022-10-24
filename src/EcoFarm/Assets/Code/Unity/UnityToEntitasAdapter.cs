using Code.ECS.Features;
using Code.Services.Interfaces;
using Code.Services.UnityImplementations;
using UnityEngine;

namespace Code.Unity
{
	public class UnityToEntitasAdapter : MonoBehaviour
	{
		[SerializeField] private UnitySceneObjectsService _sceneObjectsService;

		private AllSystems _systems;

		private void Awake()
		{
			IAllServices resources = new UnityAllResources(_sceneObjectsService);
			_systems = new AllSystems(resources);
		}

		private void Start() => _systems.Initialize();

		private void Update() => _systems.OnUpdate();

		private void OnDestroy() => _systems.TearDown();
	}
}