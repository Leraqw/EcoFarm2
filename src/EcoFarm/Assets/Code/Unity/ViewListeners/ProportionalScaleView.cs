using UnityEngine;

namespace EcoFarm
{
	public class ProportionalScaleView : BaseViewListener, IProportionalScaleListener
	{
		protected override void AddListener(GameEntity entity) => entity.AddProportionalScaleListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasProportionalScale;

		protected override void UpdateValue(GameEntity e) => OnProportionalScale(e, e.proportionalScale.Value);

		public void OnProportionalScale(GameEntity entity, float value) => transform.localScale = Vector3.one * value;
	}
}