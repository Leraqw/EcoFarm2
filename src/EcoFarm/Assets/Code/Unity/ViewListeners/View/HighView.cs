using UnityEngine;

namespace Code.Unity.ViewListeners.View
{
	public class HighView : BaseViewListener, ISpriteHighListener
	{
		[SerializeField] private Transform _target;

		public void OnSpriteHigh(GameEntity entity, float value)
		{
			var pos = _target.localScale;
			pos.y = value;
			_target.localScale = pos;
		}

		protected override void AddListener(GameEntity entity) => entity.AddSpriteHighListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasSpriteHigh;

		protected override void UpdateValue(GameEntity entity) => OnSpriteHigh(entity, entity.spriteHigh.Value);
	}
}