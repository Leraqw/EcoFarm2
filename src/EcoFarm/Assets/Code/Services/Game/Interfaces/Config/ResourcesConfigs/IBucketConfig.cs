using UnityEngine;

namespace Code
{
	public interface IBucketSpritesConfig
	{
		Sprite Empty  { get; }
		Sprite Filled { get; }
	}
}