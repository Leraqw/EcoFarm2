using System.Collections.Generic;
using Code.Data.Config;
using Code.Services.Interfaces;
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

		public UnityAllServices(ISpawnPointsService spawnPointsService)
		{
			_spawnPoints = spawnPointsService;

			_resourceLoader = new UnityResourceService();
			_storage = new UnityStorageService();
			_dataBase = new UnityDataBaseService();
			_camera = new UnityCameraService();
			_input = new UnityInputService();
		}

		GameObject IResourcesService.LoadGameObject(string path) => _resourceLoader.LoadGameObject(path);
		public Sprite LoadSprite(string path) => _resourceLoader.LoadSprite(path);

		IEnumerable<Vector2> ISpawnPointsService.Trees => _spawnPoints.Trees;

		public Vector2 Warehouse => _spawnPoints.Warehouse;

		public Vector2 Crane => _spawnPoints.Crane;

		public Vector2 Bucket => _spawnPoints.Bucket;

		void IStorage.Save<T>(T data) => _storage.Save(data);

		T IStorage.Load<T>(T defaultValue) => _storage.Load(defaultValue);

		void IStorage.Delete<T>() => _storage.Delete<T>();

		int IDataBaseService.TreesCount => _dataBase.TreesCount;
		public Vector2 ScreenToWorldPoint(Vector2 screenPosition) => _camera.ScreenToWorldPoint(screenPosition);
		public Vector2 MousePosition => _input.MousePosition;
	}
}