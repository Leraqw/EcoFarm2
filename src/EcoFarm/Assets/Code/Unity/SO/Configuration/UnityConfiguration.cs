using Code.Services.Interfaces.Config;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Unity.SO.Configuration
{
	[CreateAssetMenu(fileName = "Configuration", menuName = "ScriptableObject/Configuration")]
	public class UnityConfiguration : ScriptableObject, IConfigurationService
	{
		[FormerlySerializedAs("_balanceConfig")] [SerializeField] private BalanceConfig _balance;

		public IBalanceConfig Balance => _balance;
	}
}