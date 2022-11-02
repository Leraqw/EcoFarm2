using Code.Unity.ViewListeners;
using UnityEngine;

namespace Code.Unity.Receivers
{
	public class MouseDragReceiver : MonoBehaviour
	{
		[SerializeField] private BaseViewListener _viewListener;

		private GameEntity Entity => _viewListener.Entity;

		public void OnMouseDrag()
		{
			if (Camera.main != null)
			{
				Entity.ReplacePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
			}
		}
	}
}