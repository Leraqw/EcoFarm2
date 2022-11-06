using System;
using Code.Services.Interfaces.Config;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	public class ResourceConfig : IResourcePathConfig
	{
		public class PrefabConfig
		{
			public string Apple = "Products/Fruits/Prefabs/Apple";
			public string Tree = "Trees/Prefabs/Tree";
			public string BedPlug = "Environment/Trees Beds/Prefabs/Tree Bed Plug";
			public string Warehouse = "Environment/Warehouse/Prefabs/Warehouse";
			public string Crane = "Environment/Crane/Prefabs/Crane";
			public string Bucket = "Environment/Bucket/Prefabs/Bucket";
		}

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