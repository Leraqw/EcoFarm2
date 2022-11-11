using UnityEngine;

namespace Code.Services.Interfaces.Config.ResourcesConfigs
{
	public interface IPrefabConfig
	{
		GameObject Apple     { get; }
		string     Tree      { get; }
		string     BedPlug   { get; }
		string     Warehouse { get; }
		string     Crane     { get; }
		string     Bucket    { get; }
	}
}