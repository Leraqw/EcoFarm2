using UnityEngine;

namespace Code.Unity.ViewListeners
{
	public class PositionView : BaseViewListener, IPositionListener
	{
		protected override void AddListener(GameEntity entity) => entity.AddPositionListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasPosition;

		protected override void UpdateValue(GameEntity entity) => OnPosition(entity, entity.position.Value);

		public void OnPosition(GameEntity entity, Vector2 value) => transform.position = value;
	}
}