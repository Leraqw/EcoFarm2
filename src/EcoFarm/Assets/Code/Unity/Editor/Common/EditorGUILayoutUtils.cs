using System;
using UnityEditor;
using UnityEngine;

namespace EcoFarm.Unity.Editor.Common
{
	public static class EditorGUILayoutUtils
	{
		public static void AsHorizontalGroup(Action @this)
		{
			EditorGUILayout.BeginHorizontal();
			@this();
			EditorGUILayout.EndHorizontal();
		}

		public static void AsHorizontalGroupAlignCenter(params Action[] actions)
		{
			void AsFlexible()
			{
				foreach (var action in actions)
				{
					GUILayout.FlexibleSpace();
					action();
					GUILayout.FlexibleSpace();
				}
			}

			AsHorizontalGroup(AsFlexible);
		}

		public static EditorWindow WithTitle(this EditorWindow @this, string title)
		{
			@this.titleContent = new GUIContent(title);
			return @this;
		}
	}
}