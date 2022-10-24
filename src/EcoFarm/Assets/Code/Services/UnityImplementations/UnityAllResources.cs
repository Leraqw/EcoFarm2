using System.Collections.Generic;
using Code.Data;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityAllResources : IAllServices
	{
		private readonly IResourcesService _resourceLoader;
		private readonly ISceneObjectsService _sceneObjects;
		private readonly IStorageService _storage;

		public UnityAllResources(ISceneObjectsService sceneObjectsService)
		{
			_sceneObjects = sceneObjectsService;

			_resourceLoader = new UnityResourceService();
			_storage = new UnityStorageService();
		}

		GameObject IResourcesService.LoadGameObject(string path) => _resourceLoader.LoadGameObject(path);

		List<Transform> ISceneObjectsService.TreeSpawnPositions => _sceneObjects.TreeSpawnPositions;

		void IStorage.Save<T>(T data) => _storage.Save(data);

		T IStorage.Load<T>(T defaultValue) => _storage.Load(defaultValue);

		void IStorage.Delete<T>() => _storage.Delete<T>();
	}
}