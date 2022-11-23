using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.ResourcesConfigs
{
	public interface IWaterCleanerConfig
	{
		Sprite Clean { get; }
		Sprite Dirty { get; }
	}
}