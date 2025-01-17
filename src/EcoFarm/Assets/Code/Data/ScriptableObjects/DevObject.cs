using UnityEngine;

namespace EcoFarm
{
	public abstract class DevObject : ScriptableObject
	{
		[field: SerializeField] public ItemName Title       { get; private set; }
		[field: SerializeField] public string Description { get; private set; }
		[field: SerializeField] public int    Price       { get; private set; }
		[field: SerializeField] public Sprite Sprite      { get; private set; }
	}
}