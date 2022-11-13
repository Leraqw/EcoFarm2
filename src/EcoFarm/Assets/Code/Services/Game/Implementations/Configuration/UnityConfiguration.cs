using Code.Services.Game.Implementations.Configuration.ResourcesConfigs;
using Code.Services.Game.Interfaces.Config;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration
{
	[CreateAssetMenu(fileName = "Configuration", menuName = "ScriptableObject/Configuration")]
	public class UnityConfiguration : ScriptableObject, IConfigurationService
	{
		[SerializeField] private BalanceConfig _balance;
		[SerializeField] private CommonConfig _common;
		[SerializeField] private ResourceConfig _resource;

		public IBalanceConfig Balance => _balance;

		public ICommonConfig Common => _common;

		public IResourceConfig Resource => _resource;
	}
}