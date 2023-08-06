using EcoFarmModel;
using UnityEngine;

namespace EcoFarm
{
	public class UnityGlobalServices : IGlobalServices
	{
		private readonly IResourcesService _resourceLoader;
		private readonly IStorageService _storage;
		private readonly IDataService _data;
		private readonly ICameraService _camera;
		private readonly IInputService _input;
		private readonly ISceneTransferService _scene;

		public UnityGlobalServices()
		{
			_resourceLoader = new UnityResourceService();
			_storage = new UnityStorageService();
			_data = new StorageAccess();
			_camera = new UnityCameraService();
			_input = new UnityInputService();
			_scene = new UnitySceneTransferService();
		}

		GameObject IResourcesService.LoadGameObject(string path) => _resourceLoader.LoadGameObject(path);

		Sprite IResourcesService.LoadSprite(string path) => _resourceLoader.LoadSprite(path);

		void IStorage.Save<T>(T data) => _storage.Save(data);

		T IStorage.Load<T>(T defaultValue) => _storage.Load(defaultValue);

		void IStorage.Delete<T>() => _storage.Delete<T>();

		Storage IDataService.Storage => _data.Storage;

		Vector2 ICameraService.ScreenToWorldPoint(Vector2 value) => _camera.ScreenToWorldPoint(value);

		Vector2 IInputService.MousePosition => _input.MousePosition;

		void ISceneTransferService.ToMainMenuScene() => _scene.ToMainMenuScene();

		void ISceneTransferService.ToGameplayScene() => _scene.ToGameplayScene();

		void ISceneTransferService.ToGameResultScene() => _scene.ToGameResultScene();

		void ISceneTransferService.ToLevelChoice() => _scene.ToLevelChoice();
	}
}