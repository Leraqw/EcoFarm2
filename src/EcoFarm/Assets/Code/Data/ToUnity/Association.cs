using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	public class Association
	{
		public string Title;
		public Sprite Sprite;

		public Association(string title, Sprite sprite = null)
		{
			Title = title;
			Sprite = sprite;
		}
	}
}