using System.IO;
using UnityEngine;

namespace Code.Data
{
	public class UnityJsonStorage : IStorage
	{
		public void Save<T>(T data)
		{
			var json = JsonUtility.ToJson(data, prettyPrint: true);
			File.WriteAllText(GetPath<T>(), json);
		}

		public T Load<T>(T defaultValue)
		{
			if (File.Exists(GetPath<T>()) == false)
			{
				Save(defaultValue);
			}

			return LoadInner<T>();
		}

		private T LoadInner<T>()
		{
			var json = File.ReadAllText(GetPath<T>());
			return JsonUtility.FromJson<T>(json);
		}

		public string GetPath<T>()
		{
			var directory = $"{Application.persistentDataPath}/Data/";

			if (Directory.Exists(directory) == false)
			{
				Directory.CreateDirectory(directory);
			}

			return directory + $"{typeof(T).Name}.json";
		}
	}
}