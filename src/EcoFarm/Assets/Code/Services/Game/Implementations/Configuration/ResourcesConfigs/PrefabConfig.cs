using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class PrefabConfig : IPrefabConfig
	{
		[field: SerializeField] public GameObject Apple        { get; private set; }
		[field: SerializeField] public GameObject Tree         { get; private set; }
		[field: SerializeField] public GameObject BedPlug      { get; private set; }
		[field: SerializeField] public GameObject Warehouse    { get; private set; }
		[field: SerializeField] public GameObject Crane        { get; private set; }
		[field: SerializeField] public GameObject Bucket       { get; private set; }
		[field: SerializeField] public GameObject Sign         { get; private set; }
		[field: SerializeField] public GameObject Factory      { get; private set; }
		[field: SerializeField] public GameObject Windmill     { get; private set; }
		[field: SerializeField] public GameObject AppleJuice   { get; private set; }
		[field: SerializeField] public GameObject WaterCleaner { get; private set; }
	}
}