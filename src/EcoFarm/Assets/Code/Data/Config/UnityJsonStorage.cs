using System.IO;
using UnityEngine;

namespace Code.Data.Config
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

		public void Delete<T>() => File.Delete(GetPath<T>());

		private static T LoadInner<T>()
		{
			var json = File.ReadAllText(GetPath<T>());
			return JsonUtility.FromJson<T>(json);
		}

		private static string GetPath<T>()
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