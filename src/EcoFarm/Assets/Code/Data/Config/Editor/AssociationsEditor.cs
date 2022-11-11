// ReSharper disable Unity.PerformanceCriticalCodeInvocation - we don't care about performance in the editor
using Code.Data.ToUnity;
using UnityEditor;
using UnityEngine;

namespace Code.Data.Config.Editor
{
	[CustomEditor(typeof(Associations))]
	public class AssociationsEditor : UnityEditor.Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			GUILayout.Button("Update Resources").OnPress(((Associations)target).UpdateResources);
		}
	}
}