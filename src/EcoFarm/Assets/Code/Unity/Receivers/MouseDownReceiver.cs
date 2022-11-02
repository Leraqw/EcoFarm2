using Code.Unity.ViewListeners;
using UnityEngine;

namespace Code.Unity.Receivers
{
	public class MouseDownReceiver : MonoBehaviour
	{
		[SerializeField] private BaseViewListener _viewListener;

		public void OnMouseDown() => _viewListener.Entity.isMouseDown = true;
	}
}