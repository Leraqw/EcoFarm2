using System;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	public class BucketSpritesConfig : IBucketSpritesConfig
	{
		[field: SerializeField] public string Empty  { get; private set; } = "Environment/Bucket/Art/BucketEmpty";
		[field: SerializeField] public string Filled { get; private set; } = "Environment/Bucket/Art/BucketFilled";
	}
}