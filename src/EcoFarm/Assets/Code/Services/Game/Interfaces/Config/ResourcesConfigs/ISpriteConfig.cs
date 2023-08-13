﻿

namespace EcoFarm
{
	public interface ISpriteConfig
	{
		IBucketSpritesConfig Bucket       { get; }
		ITreeSpritesConfig   Tree         { get; }
		IWaterCleanerConfig  WaterCleaner { get; }
	}
}