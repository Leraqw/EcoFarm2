using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code
{
	public class WindowSell : MonoBehaviour
	{
		[field: SerializeField] public Slider          CountToSellSlider { get; private set; }
		[field: SerializeField] public TextMeshProUGUI ProductsCount     { get; private set; }
		[field: SerializeField] public TextMeshProUGUI CoinsReceiveCount { get; private set; }
	}
}