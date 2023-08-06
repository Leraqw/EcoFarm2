using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
	public class BuildViewContainer : MonoBehaviour
	{
		[field: SerializeField] public TextMeshProUGUI TitleTextMesh       { get; private set; }
		[field: SerializeField] public TextMeshProUGUI DescriptionTextMesh { get; private set; }
		[field: SerializeField] public Image           Image               { get; private set; }
		[field: SerializeField] public TextMeshProUGUI PriceTextMesh       { get; private set; }
	}
}