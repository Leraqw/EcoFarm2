using UnityEngine;

namespace EcoFarm
{
	public class PositionAuthoring : AuthoringBase
	{
		[SerializeField] private Transform _transform;

		public override void Register(ref GameEntity entity) => entity.AddPosition(_transform.position);
	}
}