using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class GlobalEntitasAdapter : MonoBehaviour
	{
		private GlobalSystems _systems;

		[Inject]
		public void Construct(GlobalSystems systems)
		{
			_systems = systems;
		}
		
		private void Start()
		{
			_systems.Initialize();
		}

		private void Update()
		{
			_systems.Execute();
			_systems.Cleanup();
		}

		private void OnDestroy() => _systems.TearDown();
	}
}