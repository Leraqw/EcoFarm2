using UnityEngine;

namespace Code.Services.Interfaces.Config.ResourcesConfigs
{
	public interface IBucketSpritesConfig
	{
		Sprite Empty  { get; }
		Sprite Filled { get; }
	}
}