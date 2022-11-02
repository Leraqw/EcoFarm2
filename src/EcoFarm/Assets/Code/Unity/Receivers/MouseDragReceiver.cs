using Code.Unity.ViewListeners;
using UnityEngine;

namespace Code.Unity.Receivers
{
	public class MouseDragReceiver : MonoBehaviour
	{
		[SerializeField] private BaseViewListener _viewListener;

		private GameEntity Entity => _viewListener.Entity;
		private static GameContext Context => Contexts.sharedInstance.game;

		public void OnMouseDrag()
			=> Entity.ReplacePosition(Input.mousePosition);

	}
}