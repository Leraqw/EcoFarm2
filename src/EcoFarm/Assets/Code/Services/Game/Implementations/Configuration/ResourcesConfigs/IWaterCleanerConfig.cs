using UnityEngine;

namespace EcoFarm
{
	public interface IWaterCleanerConfig
	{
		Sprite Clean { get; }
		Sprite Dirty { get; }
	}
}