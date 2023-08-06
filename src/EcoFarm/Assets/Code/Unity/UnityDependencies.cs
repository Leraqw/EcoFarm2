using UnityEngine;

namespace EcoFarm
{
	public class UnityDependencies : MonoBehaviour
	{
		[field: SerializeField] public UnitySpawnPointsService SpawnPoints { get; private set; }

		[field: SerializeField] public UnityConfiguration UnityConfiguration { get; private set; }

		[field: SerializeField] public UnityUiService UiService { get; private set; }

		[field: SerializeField] public RegistrableEntityBehaviour[] EntityBehaviours { get; private set; }
	}
}