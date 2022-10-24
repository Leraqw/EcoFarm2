using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Unity
{
	public class UnitySceneObjectsService : MonoBehaviour, ISceneObjectsService
	{
		[SerializeField] private Transform _debugTreeSpawnPosition;
		
		public Transform DebugTreeSpawnPosition => _debugTreeSpawnPosition;
	}
}