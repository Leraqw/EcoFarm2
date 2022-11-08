using System.Collections.Generic;
using Code.Data.Config;
using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;
using Code.Unity;
using Code.Unity.Containers;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityAllServices : IAllServices
	{
		private readonly ISpawnPointsService _spawnPoints;
		private readonly IResourcesService _resourceLoader;
		private readonly IStorageService _storage;
		private readonly IDataBaseService _dataBase;
		private readonly ICameraService _camera;
		private readonly IInputService _input;
		private readonly IConfigurationService _configuration;
		private readonly IUiService _ui;

		public UnityAllServices(UnityDependencies dependencies)
		{
			_spawnPoints = dependencies.SpawnPoints;
			_configuration = dependencies.UnityConfiguration;
			_ui = dependencies.UiService;

			_resourceLoader = new UnityResourceService();
			_storage = new UnityStorageService();
			_dataBase = new UnityDataBaseService();
			_camera = new UnityCameraService();
			_input = new UnityInputService();
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

		int IDataBaseService.TreesCount => _dataBase.TreesCount;

		Vector2 ICameraService.ScreenToWorldPoint(Vector2 value) => _camera.ScreenToWorldPoint(value);

		Vector2 IInputService.MousePosition => _input.MousePosition;

		IBalanceConfig IConfigurationService.Balance => _configuration.Balance;

		ICommonConfig IConfigurationService.Common => _configuration.Common;

		IResourcePathConfig IConfigurationService.ResourcePath => _configuration.ResourcePath;

		GameObject IUiService.CoinsView => _ui.CoinsView;

		GameObject IUiService.AppleView => _ui.AppleView;

		ClosableWindow IUiService.SellWindow => _ui.SellWindow;
	}
}