using System;
using Code.Data.ToUnity;
using Code.Services.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration.ResourcesConfigs
{
	[Serializable]
	public class ResourceConfig : IResourceConfig
	{
		[SerializeField] private PrefabConfig _prefab;
		[SerializeField] private SpriteConfig _sprite;

		public IPrefabConfig Prefab => _prefab;

		public ISpriteConfig Sprite => _sprite;

		[field: SerializeField] public AssociationsCollection Associations { get; private set; }
	}
}