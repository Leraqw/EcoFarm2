
using UnityEngine;

namespace EcoFarm
{
	public class WindowScroll : MonoBehaviour
	{
		[field: SerializeField] public BaseViewListener Listener { get; private set; }
		[field: SerializeField] public RectTransform ContentView { get; private set; }
	}
}