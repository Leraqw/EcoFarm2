using UnityEngine;

namespace Code.Unity.Receivers
{
	public class MouseClickReceiver : MonoBehaviour
	{
		public void OnMouseDown()
		{
			Debug.Log("Mouse Clicked");
		}
	}
}