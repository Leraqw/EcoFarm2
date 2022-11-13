using System.Collections.Generic;
using Code.Data.Config;
using Code.Data.StorageJson;
using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;
using Code.Services.Interfaces.Config.ResourcesConfigs;
using Code.Unity;
using EcoFarmDataModule;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityAllServices : IAllServices
	{
		private readonly IResourcesService _resourceLoader;
		private readonly IStorageService _storage;
		private readonly IDataService _data;
		private readonly ICameraService _camera;
		private readonly IInputService _input;

		private readonly ISpawnPointsService _spawnPoints;
		private readonly IConfigurationService _configuration;
		private readonly IUiService _ui;

		public UnityAllServices()
		{
			_resourceLoader = new UnityResourceService();
			_storage = new UnityStorageService();
			_data = new StorageAccess();
			_camera = new UnityCameraService();
			_input = new UnityInputService();
		}

		public UnityAllServices(UnityDependencies dependencies)
		{
			_spawnPoints = dependencies.SpawnPoints;
			_configuration = dependencies.UnityConfiguration;
			_ui = dependencies.UiService;
		}

		GameObject IResourcesService.LoadGameObject(string path) => _resourceLoader.LoadGameObject(path);

		Sprite IResourcesService.LoadSprite(string path) => _resourceLoader.LoadSprite(path);

		IEnumerable<Vector2> ISpawnPointsService.Trees => _spawnPoints.Trees;

		Vector2 ISpawnPointsService.Warehouse => _spawnPoints.Warehouse;

		Vector2 ISpawnPointsService.Crane => _spawnPoints.Crane;

		Vector2 ISpawnPointsService.Bucket => _spawnPoints.Bucket;

		void IStorage.Save<T>(T data) => _storage.Save(data);

		T IStorage.Load<T>(T defaultValue) => _storage.Load(defaultValue);

		void IStorage.Delete<T>() => _storage.Delete<T>();

		Storage IDataService.Storage => _data.Storage;

		Vector2 ICameraService.ScreenToWorldPoint(Vector2 value) => _camera.ScreenToWorldPoint(value);

		Vector2 IInputService.MousePosition => _input.MousePosition;

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