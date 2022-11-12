// ReSharper disable Unity.PerformanceCriticalCodeInvocation - we don't care about performance in the editor
using Code.Data.ToUnity;
using UnityEditor;
using static UnityEngine.GUILayout;

namespace Code.Data.Config.Editor
{
	[CustomEditor(typeof(AssociationsCollection))]
	public class AssociationsEditor : UnityEditor.Editor
	{
		private AssociationsCollection Target => (AssociationsCollection)target;

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			Button("Update Resources").OnPress(Target.UpdateResources);
		}
	}
}