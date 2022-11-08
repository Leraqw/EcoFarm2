using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.Containers
{
	public class ClosableWindow : MonoBehaviour
	{
		[field: SerializeField] public Button ButtonClose { get; private set; }
	}
}