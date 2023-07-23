using UnityEngine;

namespace Code
{
	public interface ITreeSpritesConfig
	{
		Sprite Dry    { get; }
		Sprite Normal { get; }
		Sprite Rotten { get; }
	}
}