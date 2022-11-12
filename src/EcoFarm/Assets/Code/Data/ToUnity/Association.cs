using System;
using UnityEngine;

namespace Code.Data.ToUnity
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