// ReSharper disable Unity.PerformanceCriticalCodeInvocation - we don't care about performance in the editor
using Code.Data.ToUnity;
using UnityEditor;
using UnityEngine;

namespace Code.Data.Config.Editor
{
	[CustomEditor(typeof(AssociationsCollection))]
	public class AssociationsEditor : UnityEditor.Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			GUILayout.Button("Update Resources").OnPress(((AssociationsCollection)target).UpdateResources);
		}
	}
}