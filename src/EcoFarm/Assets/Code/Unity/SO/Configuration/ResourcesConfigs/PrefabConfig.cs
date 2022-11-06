using Code.Services.Interfaces.Config.ResourcesConfigs;

namespace Code.Unity.SO.Configuration.ResourcesConfigs
{
	public class PrefabConfig : IPrefabConfig
	{
		public string Apple     { get; } = "Products/Fruits/Prefabs/Apple";
		public string Tree      { get; } = "Trees/Prefabs/Tree";
		public string BedPlug   { get; } = "Environment/Trees Beds/Prefabs/Tree Bed Plug";
		public string Warehouse { get; } = "Environment/Warehouse/Prefabs/Warehouse";
		public string Crane     { get; } = "Environment/Crane/Prefabs/Crane";
		public string Bucket    { get; } = "Environment/Bucket/Prefabs/Bucket";
	}
}