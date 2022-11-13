using Code.Services.Game.Implementations;
using Code.Services.Game.Implementations.Configuration;
using Code.Services.Game.Implementations.Ui;
using UnityEngine;

namespace Code.Unity
{
	public class UnityDependencies : MonoBehaviour
	{
		[field: SerializeField] public UnitySpawnPointsService SpawnPoints { get; private set; }

		[field: SerializeField] public UnityConfiguration UnityConfiguration { get; private set; }

		[field: SerializeField] public UnityUiService UiService { get; private set; }
	}
}