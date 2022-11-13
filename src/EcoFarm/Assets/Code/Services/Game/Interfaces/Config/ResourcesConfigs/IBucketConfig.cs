using UnityEngine;

namespace Code.Services.Game.Interfaces.Config.ResourcesConfigs
{
	public interface IBucketSpritesConfig
	{
		Sprite Empty  { get; }
		Sprite Filled { get; }
	}
}