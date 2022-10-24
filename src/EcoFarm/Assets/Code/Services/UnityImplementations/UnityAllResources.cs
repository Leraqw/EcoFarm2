using System.Collections.Generic;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityAllResources : IAllServices
	{
		private readonly IResourcesService _resourceLoader;
		private readonly Transform _debugTreeSpawnPosition;
		private readonly ISceneObjectsService _sceneObjects;

		public UnityAllResources(ISceneObjectsService sceneObjectsService)
		{
			_resourceLoader = new UnityResourceService();
			_sceneObjects = sceneObjectsService;
		}

		GameObject IResourcesService.LoadGameObject(string path) => _resourceLoader.LoadGameObject(path);

		List<Transform> ISceneObjectsService.TreeSpawnPositions => _sceneObjects.TreeSpawnPositions;
	}
}