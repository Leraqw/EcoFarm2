using Code.Utils.Extensions;
using UnityEngine;

namespace Code.Unity.ViewListeners
{
	public class PositionView : MonoBehaviour, IPositionListener
	{
		public void Register(GameEntity entity) => entity.Do((e) => e.AddPositionListener(this))
		                                                 .Do(UpdatePosition, @if: (e) => e.hasPosition);

		private void UpdatePosition(GameEntity entity) => OnPosition(entity, entity.position.Value);

		public void OnPosition(GameEntity entity, Vector3 value) => transform.position = value;
	}
}