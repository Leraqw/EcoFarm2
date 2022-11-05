using Code.Services.Interfaces.Config;
using UnityEngine;

namespace Code.Unity.SO.Config
{
	[CreateAssetMenu(fileName = "Configuration", menuName = "ScriptableObject/Configuration")]
	public class Configuration : ScriptableObject, IConfigurationService
	{
		[SerializeField] private BalanceConfig _balanceConfig;

		public IBalanceConfig Balance => _balanceConfig;
	}
}