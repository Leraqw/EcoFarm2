// ReSharper disable Unity.PerformanceCriticalCodeInvocation - we don't care about performance in the editor
using UnityEditor;
using static Code.Data.Config.Editor.EditorGUILayoutUtils;
using static UnityEditor.EditorUtility;
using static UnityEngine.GUILayout;

namespace Code.Data.Config.Editor
{
	public class DataLoaderWindow : EditorWindow
	{
		private const int DllPathLabelWidth = 50;
		private const int OpenFileButtonWidth = 75;
		private string _pathToDlls;

		private float PathTextFieldWidth => position.width - (OpenFileButtonWidth + DllPathLabelWidth);

		[MenuItem("Tools/Eco-Farm/Data Loader Window")]
		private static void ShowWindow() => GetWindow<DataLoaderWindow>().WithTitle("Data Loader").Show();

		private void OnGUI()
		{
			AsHorizontalGroupAlignCenter(DllPathLabel, DllPathTextField, DllPathOpenFileButton);
			Button("Copy").OnPress(() => FilesWorker.CopyDlls(_pathToDlls));
			Space(50);
			AsHorizontalGroupAlignCenter(ButtonGenerate);
		}

		private void DllPathLabel() => Label("Dll path");

		private void DllPathTextField() => _pathToDlls = TextField(_pathToDlls, Width(PathTextFieldWidth));

		private void DllPathOpenFileButton() => Button("Open file").OnPress(GetPathToDll);

		private void ButtonGenerate() => Button("Generate", Width(position.width / 2)).OnPress(TempDataCreator.Create);

		private void GetPathToDll() => _pathToDlls = OpenFolderPanel("Open folder", string.Empty, string.Empty);
	}
}