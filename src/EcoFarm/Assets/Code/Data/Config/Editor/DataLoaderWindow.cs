// ReSharper disable Unity.PerformanceCriticalCodeInvocation - we don't care about performance in the editor
using UnityEditor;
using UnityEngine;
using static Code.Data.Config.Editor.EditorGUILayoutUtils;
using static UnityEditor.EditorUtility;
using static UnityEngine.GUILayout;

namespace Code.Data.Config.Editor
{
	public class DataLoaderWindow : EditorWindow
	{
		private string _pathToDlls;

		[MenuItem("Tools/Eco-Farm/Data Loader Window")]
		private static void ShowWindow() => GetWindow<DataLoaderWindow>().WithTitle("Data Loader").Show();

		private void OnGUI()
		{
			AsHorizontalGroup(DrawOpenDll);
			Button("Copy").OnPress(() => FilesWorker.CopyDlls(_pathToDlls));
			
			Button("Generate").OnPress(TempDataCreator.Create);
		}

		private void DrawOpenDll()
		{
			Label("Dll path", new GUIStyle(GUI.skin.label), Width(50));
			_pathToDlls = TextField(_pathToDlls);
			Button("Open file", new GUIStyle(GUI.skin.button), Width(75)).OnPress(GetPathToDll);
		}

		private void GetPathToDll() => _pathToDlls = OpenFolderPanel("Open folder", string.Empty, string.Empty);
	}
}