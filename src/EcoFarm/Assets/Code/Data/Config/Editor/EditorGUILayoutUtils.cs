using System;
using UnityEditor;
using UnityEngine;

namespace Code.Data.Config.Editor
{
	public static class EditorGUILayoutUtils
	{
		public static void AsHorizontalGroup(Action @this)
		{
			EditorGUILayout.BeginHorizontal();
			@this();
			EditorGUILayout.EndHorizontal();
		}

		public static EditorWindow WithTitle(this EditorWindow @this, string title)
		{
			@this.titleContent = new GUIContent(title);
			return @this;
		}
	}
}