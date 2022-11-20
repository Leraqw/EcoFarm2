using UnityEngine;

namespace Code.Services.Game.Interfaces.Config.ResourcesConfigs
{
	public interface IPrefabConfig
	{
		GameObject Apple      { get; }
		GameObject Tree       { get; }
		GameObject BedPlug    { get; }
		GameObject Warehouse  { get; }
		GameObject Crane      { get; }
		GameObject Bucket     { get; }
		GameObject Sign       { get; }
		GameObject Factory    { get; }
		GameObject Windmill   { get; }
		GameObject AppleJuice { get; }
	}
}