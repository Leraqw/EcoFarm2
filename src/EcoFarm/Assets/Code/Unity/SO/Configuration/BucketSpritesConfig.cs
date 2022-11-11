using System;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	public class BucketSpritesConfig : IBucketSpritesConfig
	{
		[field: SerializeField] public Sprite Empty  { get; private set; }
		[field: SerializeField] public Sprite Filled { get; private set; }
	}
}