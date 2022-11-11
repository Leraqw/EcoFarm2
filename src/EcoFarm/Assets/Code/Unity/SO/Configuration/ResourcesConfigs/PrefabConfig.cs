using System;
using Code.Services.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration.ResourcesConfigs
{
	[Serializable]
	public class PrefabConfig : IPrefabConfig
	{
		[field: SerializeField] public GameObject Apple { get; private set;}
		[field: SerializeField] public GameObject Tree  { get; private set;}
		[field: SerializeField] public string BedPlug   { get; private set;} = "Environment/Trees Beds/Prefabs/Tree Bed Plug";
		[field: SerializeField] public string Warehouse { get; private set;} = "Environment/Warehouse/Prefabs/Warehouse";
		[field: SerializeField] public string Crane     { get; private set;} = "Environment/Crane/Prefabs/Crane";
		[field: SerializeField] public string Bucket    { get; private set;} = "Environment/Bucket/Prefabs/Bucket";
	}
}