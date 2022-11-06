using System;
using Code.Services.Interfaces.Config;
using Code.Services.Interfaces.Config.ResourcesConfigs;
using Code.Unity.SO.Configuration.ResourcesConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	public class ResourceConfig : IResourcePathConfig
	{
		[SerializeField] private PrefabConfig _prefab;

		public IPrefabConfig Prefab => _prefab;


		[Serializable]
		public class SpriteConfig
		{
			[Serializable]
			public class Bucket
			{
				public string Empty  { get; } = "Environment/Bucket/Art/BucketEmpty";
				public string Filled { get; } = "Environment/Bucket/Art/BucketFilled";
			}
		}
	}
}