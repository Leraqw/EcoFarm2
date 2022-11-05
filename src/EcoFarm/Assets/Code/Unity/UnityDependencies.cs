using Code.Services.Interfaces;
using Code.Services.UnityImplementations;
using Code.Unity.SO.Config;
using UnityEngine;

namespace Code.Unity
{
	public class UnityDependencies : MonoBehaviour
	{
		[SerializeField] private UnitySpawnPointsService _spawnPoints;
		[SerializeField] private Configuration _configuration;

		public ISpawnPointsService SpawnPoints => _spawnPoints;
		public Configuration Configuration => _configuration;
	}
}