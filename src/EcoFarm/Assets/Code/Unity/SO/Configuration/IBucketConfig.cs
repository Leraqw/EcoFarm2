using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	public interface IBucketSpritesConfig
	{
		Sprite Empty  { get; }
		Sprite Filled { get; }
	}
}