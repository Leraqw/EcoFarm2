using UnityEngine;

namespace EcoFarm
{
	public abstract class DevelopmentObjectSO : ScriptableObject
	{
		[field: SerializeField] public string Title       { get; private set; }
		[field: SerializeField] public string Description { get; private set; }
		[field: SerializeField] public int    Price       { get; private set; }
	}
}