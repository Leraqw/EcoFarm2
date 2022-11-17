// ReSharper disable Unity.PerformanceCriticalCodeInvocation - we don't care about performance in the editor
using Code.Data.ToUnity;
using Code.Unity.Editor.Common;
using UnityEditor;
using static UnityEngine.GUILayout;

namespace Code.Unity.Editor.Associations
{
	[CustomEditor(typeof(SpriteSheet))]
	public class AssociationsEditor : UnityEditor.Editor
	{
		private SpriteSheet Target => (SpriteSheet)target;

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			Button("Update Resources").OnPress(Target.UpdateResources);
		}
	}
}