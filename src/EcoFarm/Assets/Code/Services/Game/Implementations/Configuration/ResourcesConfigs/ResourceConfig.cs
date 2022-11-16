using System;
using Code.Data.ToUnity;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.ResourcesConfigs
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