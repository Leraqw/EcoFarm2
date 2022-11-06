using Code.Services.Interfaces.Config;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[CreateAssetMenu(fileName = "Configuration", menuName = "ScriptableObject/Configuration")]
	public class UnityConfiguration : ScriptableObject, IConfigurationService
	{
		[SerializeField] private BalanceConfig _balance;
		[SerializeField] private CommonConfig _common;

		public IBalanceConfig Balance => _balance;

		public ICommonConfig Common => _common;
	}
}