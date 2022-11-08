using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.Containers
{
	public class WindowSell : MonoBehaviour
	{
		[field: SerializeField] public Slider CountToSellSlider { get; private set; }
	}
}