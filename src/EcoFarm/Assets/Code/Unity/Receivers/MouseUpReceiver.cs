
using UnityEngine;

namespace EcoFarm
{
	public class MouseUpReceiver : MonoBehaviour
	{
		[SerializeField] private BaseViewListener _viewListener;

		public void OnMouseUp() => _viewListener.Entity.isMouseUp = true;
	}
}