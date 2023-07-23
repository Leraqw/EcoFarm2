
using UnityEngine;

namespace Code
{
	public class WindowResources : MonoBehaviour
	{
		[field: SerializeField] public ProgressBarView WaterIndicator  { get; private set; }
		[field: SerializeField] public ProgressBarView EnergyIndicator { get; private set; }
	}
}