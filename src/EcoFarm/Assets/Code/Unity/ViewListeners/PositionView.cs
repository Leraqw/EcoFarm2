using UnityEngine;

namespace Code.Unity.ViewListeners
{
	public class PositionView : MonoBehaviour, IPositionListener
	{
		public void Register(GameEntity entity) => entity.AddPositionListener(this);

		public void OnPosition(GameEntity entity, Vector3 value) => transform.position = value;
	}
}