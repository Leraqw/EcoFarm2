using Code.Unity.ViewListeners.UI;
using UnityEngine;

namespace Code.Unity.Containers
{
	public class WindowResources : MonoBehaviour
	{
		[field: SerializeField] public ProgressBarView WaterIndicator  { get; private set; }
		[field: SerializeField] public ProgressBarView EnergyIndicator { get; private set; }
	}
}