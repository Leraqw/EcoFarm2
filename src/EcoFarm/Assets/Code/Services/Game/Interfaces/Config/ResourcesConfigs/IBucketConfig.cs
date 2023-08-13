using UnityEngine;

namespace EcoFarm
{
	public interface IBucketSpritesConfig
	{
		Sprite Empty  { get; }
		Sprite Filled { get; }
	}
}