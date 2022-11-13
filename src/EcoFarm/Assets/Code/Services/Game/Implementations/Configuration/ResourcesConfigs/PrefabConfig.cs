using System;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.ResourcesConfigs
{
	[Serializable]
	public class PrefabConfig : IPrefabConfig
	{
		[field: SerializeField] public GameObject Apple     { get; private set; }
		[field: SerializeField] public GameObject Tree      { get; private set; }
		[field: SerializeField] public GameObject BedPlug   { get; private set; }
		[field: SerializeField] public GameObject Warehouse { get; private set; }
		[field: SerializeField] public GameObject Crane     { get; private set; }
		[field: SerializeField] public GameObject Bucket    { get; private set; }
	}
}