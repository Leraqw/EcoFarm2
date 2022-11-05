using System;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Unity.SO
{
	[CreateAssetMenu(fileName = "Configuration", menuName = "ScriptableObject/Configuration")]
	public class Configuration : ScriptableObject, IConfigurationService
	{
		[SerializeField] private BalanceConfig _balanceConfig;

		public IConfigurationService.IBalanceConfig Balance => _balanceConfig;

		[Serializable]
		public class BalanceConfig : IConfigurationService.IBalanceConfig
		{
			[field: SerializeField] public float DroughtDuration { get; private set; }
		}
	}
}