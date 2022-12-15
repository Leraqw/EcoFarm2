using UnityEngine;

namespace Code
{
	public class PositionAuthoring : RegistrarBase
	{
		[SerializeField] private Transform _transform;

		public override void Register(ref GameEntity entity) => entity.AddPosition(_transform.position);
	}
}