using Code.Services.UnityImplementations;
using Code.Unity.SO.Config;
using UnityEngine;

namespace Code.Unity
{
	public class UnityDependencies : MonoBehaviour
	{
		[field: SerializeField] public UnitySpawnPointsService SpawnPoints { get; private set; }
		[field: SerializeField] public Configuration Configuration { get; private set; }
	}
}