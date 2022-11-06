﻿using Code.Services.Interfaces.Config;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[CreateAssetMenu(fileName = "Configuration", menuName = "ScriptableObject/Configuration")]
	public class UnityConfiguration : ScriptableObject, IConfigurationService
	{
		[SerializeField] private BalanceConfig _balance;
		[SerializeField] private CommonConfig _common;
		[SerializeField] private ResourceConfig _resource;

		public IBalanceConfig Balance => _balance;

		public ICommonConfig Common => _common;

		public IResourcePathConfig ResourcePath => _resource;
	}
}