using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.Containers
{
	public class BuildView : MonoBehaviour
	{
		[field: SerializeField] public TextMeshProUGUI TitleTextMesh       { get; private set; }
		[field: SerializeField] public TextMeshProUGUI DescriptionTextMesh { get; private set; }
		[field: SerializeField] public Image           Image               { get; private set; }
	}
}