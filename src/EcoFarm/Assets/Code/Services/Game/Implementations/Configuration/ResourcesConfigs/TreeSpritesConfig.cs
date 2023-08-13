using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class TreeSpritesConfig : ITreeSpritesConfig
	{
		[field: SerializeField] public Sprite Dry    { get; private set; }
		[field: SerializeField] public Sprite Normal { get; private set; }
		[field: SerializeField] public Sprite Rotten { get; private set; }
	}
}