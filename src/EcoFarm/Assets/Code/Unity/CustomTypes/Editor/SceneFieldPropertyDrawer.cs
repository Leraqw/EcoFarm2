using UnityEditor;
using UnityEngine;

namespace Code.Unity.CustomTypes.Editor
{

	[CustomPropertyDrawer(typeof(SceneField))]
	public class SceneFieldPropertyDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.BeginProperty(position, GUIContent.none, property);

			DrawProperty(position, property, label);

			EditorGUI.EndProperty();
		}

		private static void DrawProperty(Rect position, SerializedProperty property, GUIContent label)
		{
			var scene = property.FindPropertyRelative("_scene");
			position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

			if (scene is null)
			{
				return;
			}

			scene.objectReferenceValue = EditorGUI.ObjectField
			(
				position,
				scene.objectReferenceValue,
				typeof(SceneAsset),
				allowSceneObjects: false
			);
		}
	}}