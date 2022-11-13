using System;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration.ResourcesConfigs
{
	[Serializable]
	public class SpriteConfig : ISpriteConfig
	{
		[SerializeField] private BucketSpritesConfig _bucket;
		[SerializeField] private TreeSpritesConfig _tree;

		public IBucketSpritesConfig Bucket => _bucket;
		public ITreeSpritesConfig   Tree   => _tree;
	}
}