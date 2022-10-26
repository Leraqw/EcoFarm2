using System.Collections.Generic;
using Code.Data.Config;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityAllServices : IAllServices
	{
		private readonly ISceneObjectsService _sceneObjects;
		private readonly IResourcesService _resourceLoader;
		private readonly IStorageService _storage;
		private readonly IDataBaseService _dataBase;

		public UnityAllServices(ISceneObjectsService sceneObjectsService)
		{
			_sceneObjects = sceneObjectsService;

			_resourceLoader = new UnityResourceService();
			_storage = new UnityStorageService();
			_dataBase = new UnityDataBaseService(_storage);
		}

		GameObject IResourcesService.LoadGameObject(string path) => _resourceLoader.LoadGameObject(path);

		IEnumerable<Vector2> ISceneObjectsService.TreeSpawnPositions => _sceneObjects.TreeSpawnPositions;

		void IStorage.Save<T>(T data) => _storage.Save(data);

		T IStorage.Load<T>(T defaultValue) => _storage.Load(defaultValue);

		void IStorage.Delete<T>() => _storage.Delete<T>();

		int IDataBaseService.TreesCount => _dataBase.TreesCount;
	}
}