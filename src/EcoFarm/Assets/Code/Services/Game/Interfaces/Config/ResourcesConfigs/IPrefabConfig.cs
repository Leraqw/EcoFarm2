using UnityEngine;

namespace EcoFarm
{
	public interface IPrefabConfig
	{
		GameObject Apple        { get; }
		GameObject Pear        { get; }
		GameObject AppleTree    { get; }
		GameObject PearTree    { get; }
		GameObject BedPlug      { get; }
		GameObject Warehouse    { get; }
		GameObject Crane        { get; }
		GameObject Bucket       { get; }
		GameObject Sign         { get; }
		GameObject Factory      { get; }
		GameObject Windmill     { get; }
		GameObject AppleJuice   { get; }
		GameObject WaterCleaner { get; }
	}
}