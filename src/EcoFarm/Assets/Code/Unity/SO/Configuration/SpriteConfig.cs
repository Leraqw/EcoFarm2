using System;
using Code.Services.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	public class SpriteConfig : ISpriteConfig
	{
		[SerializeField] private BucketSpritesConfig _bucket;

		public IBucketSpritesConfig Bucket => _bucket;
	}
}