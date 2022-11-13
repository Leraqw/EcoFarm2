using System.Collections.Generic;
using Code.Services.Game.Interfaces;
using Code.Services.Game.Interfaces.Config;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using Code.Services.Game.Interfaces.Ui;
using Code.Unity;
using UnityEngine;

namespace Code.Services.Game.Implementations
{
	public class UnityGameServices : IGameServices
	{
		private readonly ISpawnPointsService _spawnPoints;
		private readonly IConfigurationService _configuration;
		private readonly IUiService _ui;

		public UnityGameServices(UnityDependencies dependencies)
		{
			_spawnPoints = dependencies.SpawnPoints;
			_configuration = dependencies.UnityConfiguration;
			_ui = dependencies.UiService;
		}

		IEnumerable<Vector2> ISpawnPointsService.Trees => _spawnPoints.Trees;

		Vector2 ISpawnPointsService.Warehouse => _spawnPoints.Warehouse;

		Vector2 ISpawnPointsService.Crane => _spawnPoints.Crane;

		Vector2 ISpawnPointsService.Bucket => _spawnPoints.Bucket;

		IBalanceConfig IConfigurationService.Balance => _configuration.Balance;

		ICommonConfig IConfigurationService.Common => _configuration.Common;

		IResourceConfig IConfigurationService.Resource => _configuration.Resource;

		GameObject IUiService.CoinsView => _ui.CoinsView;

		GameObject IUiService.AppleView => _ui.AppleView;

		GameObject IUiService.GoalPrefab => _ui.GoalPrefab;

		RectTransform IUiService.UiRoot => _ui.UiRoot;

		IWindowsCollection IUiService.Windows => _ui.Windows;

		IButtonsCollection IUiService.Buttons => _ui.Buttons;

		RectTransform IUiService.GoalsGroup => _ui.GoalsGroup;

		GameObject IUiService.TimerView => _ui.TimerView;
	}
}