using Code.Services.UnityImplementations;
using Code.Unity.SO.Configuration;
using UnityEngine;

namespace Code.Unity
{
	public class UnityDependencies : MonoBehaviour
	{
		[field: SerializeField] public UnitySpawnPointsService SpawnPoints { get; private set; }
		[field: SerializeField] public UnityConfiguration UnityConfiguration { get; private set; }
	}
}