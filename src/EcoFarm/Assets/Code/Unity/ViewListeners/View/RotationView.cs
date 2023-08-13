using UnityEngine;

namespace EcoFarm
{
	public class RotationView : BaseViewListener, IRotationListener
	{
		public void OnRotation(GameEntity entity, float value) => transform.rotation = Quaternion.Euler(0, 0, value);

		protected override void AddListener(GameEntity entity) => entity.AddRotationListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasRotation;

		protected override void UpdateValue(GameEntity entity) => OnRotation(entity, entity.rotation.Value);
	}
}