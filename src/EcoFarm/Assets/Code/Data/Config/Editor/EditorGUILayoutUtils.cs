using System;
using UnityEditor;

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
	}
}