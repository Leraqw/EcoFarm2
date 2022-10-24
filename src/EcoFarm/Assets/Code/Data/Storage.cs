using System.IO;
using UnityEngine;

namespace Code.Data
{
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
		
		public T Load(T defaultValue)
		{
			if (File.Exists(_path) == false)
			{
				Save(defaultValue);
			}

			return LoadInner();
		}

		private T LoadInner()
		{
			var json = File.ReadAllText(_path);
			return JsonUtility.FromJson<T>(json);
		}
	}
}