using Code.Unity.ViewListeners;
using UnityEngine;

namespace Code.Unity.Containers
{
	public class WindowBuild : MonoBehaviour
	{
		[field: SerializeField] public BaseViewListener Listener { get; private set; }
		
		[field: SerializeField] public GameObject ContentView { get; private set; }
	}
}