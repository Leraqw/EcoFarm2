using UnityEditor;
using UnityEngine;

namespace Code.Unity.Editor
{
	public class DataBaseWindow : EditorWindow
	{
		[MenuItem("Tools/DataBase")]
		private static void ShowWindow()
		{
			var window = GetWindow<DataBaseWindow>();
			window.titleContent = new GUIContent("DataBase");
			window.Show();
		}

		private void OnGUI()
		{
			if (GUILayout.Button("Create DataBase"))
			{
				Debug.Log("U clicked on Create DataBase");
			}
		}
	}
}