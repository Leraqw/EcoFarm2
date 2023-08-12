using UnityEngine;

namespace EcoFarm
{
	public abstract class EnvironmentParameter : ScriptableObject
	{
		[field: SerializeField] public string Title       { get; private set; }
		[field: SerializeField] public string Description { get; private set; }
	}
}