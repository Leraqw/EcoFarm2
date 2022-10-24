using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;

namespace Code.Data
{
	public static class UnityConfigurationsCreator
	{
		private const int TreesCount = 5;

		[MenuItem("Tools/Eco-Farm/Create Config with 5 trees")]
		public static void CreateConfiguration()
		{
			var config = new Config(TreesCount);
			var storage = new Storage<Config>();
			
			storage.Save(config);

			var loaded = storage.Load();
			
			Debug.Log("loaded.TreesCount = " + loaded.TreesCount);
		}
	}

	public class Storage<T>
	{
		private readonly string _path;

		public Storage()
		{
			var directory = $"{Application.persistentDataPath}/Data/";
			_path = directory + $"{typeof(T).Name}.json";
			
			Directory.CreateDirectory(directory);
		}
		
		public void Save(T data)
		{
			var json = JsonUtility.ToJson(data, true);
			File.WriteAllText(_path, json);
		}
		
		public T Load()
		{
			var json = File.ReadAllText(_path);
			return JsonUtility.FromJson<T>(json);
		}
	}
}