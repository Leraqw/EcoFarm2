using System;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.ResourcesConfigs
{
	[Serializable]
	public class SpriteConfig : ISpriteConfig
	{
		[SerializeField] private BucketSpritesConfig _bucket;
		[SerializeField] private TreeSpritesConfig _tree;
		[SerializeField] private WaterCleanerConfig _waterCleaner;

		public IBucketSpritesConfig Bucket       => _bucket;
		public ITreeSpritesConfig   Tree         => _tree;
		public IWaterCleanerConfig  WaterCleaner => _waterCleaner;
	}
}