using Code.Unity.ViewListeners;
using Code.Utils.Extensions;
using UnityEngine;

namespace Code.Unity.Receivers
{
	public class MouseClickReceiver : MonoBehaviour
	{
		[SerializeField] private BaseViewListener _viewListener;

		private static GameContext Context => Contexts.sharedInstance.game;

		public void OnMouseDown()
			=> Context.CreateEntity()
			          .Do((e) => e.AddOnMouseClick(_viewListener.Entity))
			          .Do((e) => e.AddDebugName("OnMouseClick"));
	}
}