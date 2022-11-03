using Code.Services.Interfaces;
using Code.Services.UnityImplementations;
using UnityEngine;

namespace Code.Unity
{
	public class UnityDependencies : MonoBehaviour
	{
		[SerializeField] private UnitySpawnPointsService _spawnPoints;

		public ISpawnPointsService SpawnPoints => _spawnPoints;
	}
}