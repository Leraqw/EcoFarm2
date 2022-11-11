using UnityEngine;

namespace Code.Services.Interfaces.Config.ResourcesConfigs
{
	public interface IPrefabConfig
	{
		GameObject Apple     { get; }
		GameObject Tree      { get; }
		GameObject BedPlug   { get; }
		GameObject Warehouse { get; }
		GameObject Crane     { get; }
		GameObject Bucket    { get; }
	}
}