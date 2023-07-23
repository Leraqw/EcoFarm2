
using UnityEngine;

namespace Code
{
	public class WindowBuild : MonoBehaviour
	{
		[field: SerializeField] public BaseViewListener Listener { get; private set; }
		
		[field: SerializeField] public RectTransform ContentView { get; private set; }
	}
}