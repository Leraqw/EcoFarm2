using UnityEngine;

namespace EcoFarm
{
	public abstract class DevObject : ScriptableObject
	{
		[field: SerializeField] public string Title       { get; private set; }
		[field: SerializeField] public string Description { get; private set; }
		[field: SerializeField] public int    Price       { get; private set; }
	}
}