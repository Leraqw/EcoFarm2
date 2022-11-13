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
	public class UnityGlobalServices : IGlobalServices
	{
		private readonly IResourcesService _resourceLoader;
		private readonly IStorageService _storage;
		private readonly IDataService _data;
		private readonly ICameraService _camera;
		private readonly IInputService _input;
		public UnityGlobalServices()
		{
			_resourceLoader = new UnityResourceService();
			_storage = new UnityStorageService();
			_data = new StorageAccess();
			_camera = new UnityCameraService();
			_input = new UnityInputService();
		}
		
		GameObject IResourcesService.LoadGameObject(string path) => _resourceLoader.LoadGameObject(path);

		Sprite IResourcesService.LoadSprite(string path) => _resourceLoader.LoadSprite(path);
		
		void IStorage.Save<T>(T data) => _storage.Save(data);

		T IStorage.Load<T>(T defaultValue) => _storage.Load(defaultValue);

		void IStorage.Delete<T>() => _storage.Delete<T>();

		Storage IDataService.Storage => _data.Storage;

		Vector2 ICameraService.ScreenToWorldPoint(Vector2 value) => _camera.ScreenToWorldPoint(value);

		Vector2 IInputService.MousePosition => _input.MousePosition;

		}
}