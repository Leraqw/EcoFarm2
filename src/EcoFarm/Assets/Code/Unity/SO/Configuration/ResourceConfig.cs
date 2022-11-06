using System;
using Code.Services.Interfaces.Config;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	public class ResourceConfig : IResourcePathConfig
	{
		public class SpriteConfig
		{
			public class Bucket
			{
				public string Empty = "Environment/Bucket/Art/BucketEmpty";
				public string Filled = "Environment/Bucket/Art/BucketFilled";
			}
		}
	}
}