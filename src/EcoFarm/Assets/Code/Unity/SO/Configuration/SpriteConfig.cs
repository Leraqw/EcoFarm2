using System;
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