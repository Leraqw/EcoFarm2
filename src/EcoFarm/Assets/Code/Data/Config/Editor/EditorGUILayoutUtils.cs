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
	}
}