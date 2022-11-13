using UnityEngine;

namespace Code.Services.Game.Interfaces.Config.ResourcesConfigs
{
	public interface ITreeSpritesConfig
	{
		Sprite Dry    { get; }
		Sprite Normal { get; }
		Sprite Rotten { get; }
	}
}