
using UnityEngine;

namespace EcoFarm
{
	public class MouseDownReceiver : MonoBehaviour
	{
		[SerializeField] private BaseViewListener _viewListener;

		public void OnMouseDown() => _viewListener.Entity.isMouseDown = true;
	}
}