using System;
using Code.Services.Interfaces.Config;
using Code.Services.Interfaces.Config.ResourcesConfigs;
using Code.Unity.SO.Configuration.ResourcesConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	public class ResourceConfig : IResourceConfig
	{
		[SerializeField] private PrefabConfig _prefab;
		[SerializeField] private SpriteConfig _sprite;

		public IPrefabConfig Prefab => _prefab;

		public ISpriteConfig Sprite => _sprite;
	}
}