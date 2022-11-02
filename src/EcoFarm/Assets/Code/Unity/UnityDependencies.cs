using Code.Services.Interfaces;
using Code.Services.UnityImplementations;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Unity
{
	public class UnityDependencies : MonoBehaviour
	{
		[FormerlySerializedAs("_sceneObjects")] [SerializeField] private UnitySpawnPointsService _spawnPoints;

		public ISpawnPointsService SpawnPoints => _spawnPoints;
	}
}