// ReSharper disable Unity.PerformanceCriticalCodeInvocation - we don't care about performance in the editor
using System;
using EcoFarm.Unity.Editor.Common;
using UnityEditor;
using static EcoFarm.Unity.Editor.Common.EditorGUILayoutUtils;
using static UnityEditor.EditorUtility;
using static UnityEngine.GUILayout;

namespace EcoFarm.Unity.Editor.Data
{
	public class DataLoaderWindow : EditorWindow
	{
		private const int DllPathLabelWidth = 50;
		private const int OpenFileButtonWidth = 75;
		private string _pathToDlls = "C:/Users/nikol/Documents/source/GitHub/BdKursach/src/Shared/Model";

		private float PathTextFieldWidth => position.width - (OpenFileButtonWidth + DllPathLabelWidth);

		private float WindowWidth => position.width;

		[MenuItem("Tools/Eco-Farm/Data Loader Window")]
		private static void ShowWindow() => GetWindow<DataLoaderWindow>().WithTitle("Data Loader").Show();

		private void OnGUI()
		{
			Space(25);
			AsHorizontalGroupAlignCenter(DllPathLabel, DllPathTextField, DllPathOpenFileButton);
			AsHorizontalGroupAlignCenter(ButtonCopy);
			Space(25);
			AsHorizontalGroupAlignCenter(ButtonGenerate);
			AsHorizontalGroupAlignCenter(ButtonCreatePlayers);
		}

		private void ButtonCreatePlayers()
			=> Button("Crate Players", Width(WindowWidth / 2)).OnPress(Obsolete);

		private void ButtonCopy() => Button("Copy", Width(WindowWidth / 2)).OnPress(CopyDlls);

		private void CopyDlls() => FilesWorker.CopyDlls(_pathToDlls);

		private void DllPathLabel()     => Label("Dll path");
		private void DllPathTextField() => _pathToDlls = TextField(_pathToDlls, Width(PathTextFieldWidth));

		private void DllPathOpenFileButton() => Button("Open file").OnPress(GetPathToDll);

		private void ButtonGenerate() => Button("Generate", Width(WindowWidth / 2)).OnPress(Obsolete);

		private void GetPathToDll() => _pathToDlls = OpenFolderPanel("Open folder", string.Empty, string.Empty);

		private static void Obsolete() => throw new NotImplementedException("this functionality is obsolete");
	}
}