using UnityEngine;

namespace Code
{
	public interface IWaterCleanerConfig
	{
		Sprite Clean { get; }
		Sprite Dirty { get; }
	}
}