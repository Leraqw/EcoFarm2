using System;


using UnityEngine;

namespace Code
{
	[Serializable]
	public class ResourceConfig : IResourceConfig
	{
		[SerializeField] private PrefabConfig _prefab;
		[SerializeField] private SpriteConfig _sprite;

		public IPrefabConfig Prefab => _prefab;

		public ISpriteConfig Sprite => _sprite;

		[field: SerializeField] public SpriteSheet SpriteSheet { get; private set; }
	}
}