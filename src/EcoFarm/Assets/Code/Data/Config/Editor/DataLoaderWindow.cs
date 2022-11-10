// ReSharper disable Unity.PerformanceCriticalCodeInvocation - we don't care about performance in the editor
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using static Code.Data.Config.Editor.EditorGUILayoutUtils;
using static UnityEditor.EditorUtility;
using static UnityEngine.GUILayout;

namespace Code.Data.Config.Editor
{
	public class DataLoaderWindow : EditorWindow
	{
		private const int OpenFileButtonWidth = 75;
		private const int DllPathLabelWidth = 50;
		private string _pathToDlls;

		private float PathTextFieldWidth => position.width - (OpenFileButtonWidth + DllPathLabelWidth + 15);

		[MenuItem("Tools/Eco-Farm/Data Loader Window")]
		private static void ShowWindow() => GetWindow<DataLoaderWindow>().WithTitle("Data Loader").Show();

		private void OnGUI()
		{
			AsHorizontalGroup(DrawOpenDll);
			Button("Copy").OnPress(() => FilesWorker.CopyDlls(_pathToDlls));

			Space(50);

			AsHorizontalGroup(ButtonGenerate);
		}

		private void ButtonGenerate()
		{
			FlexibleSpace();
			Button("Generate", Width(100)).OnPress(TempDataCreator.Create);
			FlexibleSpace();
		}

		private void DrawOpenDll()
		{
			Label("Dll path", new GUIStyle(GUI.skin.label), Width(DllPathLabelWidth));
			_pathToDlls = TextField(_pathToDlls, Width(PathTextFieldWidth));
			Button("Open file", new GUIStyle(GUI.skin.button), Width(OpenFileButtonWidth)).OnPress(GetPathToDll);
		}

		private void GetPathToDll() => _pathToDlls = OpenFolderPanel("Open folder", string.Empty, string.Empty);
	}
}