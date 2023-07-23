
using UnityEngine;

namespace Code
{
	public class MouseDownReceiver : MonoBehaviour
	{
		[SerializeField] private BaseViewListener _viewListener;

		public void OnMouseDown() => _viewListener.Entity.isMouseDown = true;
	}
}