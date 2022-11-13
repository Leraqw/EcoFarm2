using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace Code.Unity.CustomTypes
{
	[Serializable]
	public class SceneField
	{
		[SerializeField] private Object _scene;

		public string SceneName => _scene.name;

		public static implicit operator string(SceneField sceneField) => sceneField.SceneName;

		public static implicit operator Scene(SceneField sceneField) => SceneManager.GetSceneByName(sceneField);
	}
}