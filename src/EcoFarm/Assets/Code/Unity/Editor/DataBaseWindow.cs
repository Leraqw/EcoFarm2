using Code.Data.DataBase;
using UnityEditor;
using UnityEngine;

namespace Code.Unity.Editor
{
	public class DataBaseWindow : EditorWindow
	{
		private DataBaseAccess _dataBase;

		public DataBaseWindow()
		{
			_dataBase = new DataBaseAccess();
		}
		
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
				_dataBase.CreateDataBase();
			}
		}
	}
}