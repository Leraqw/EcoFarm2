using UnityEngine;

namespace EcoFarm
{
	public class RadiusAuthoring : AuthoringBase
	{
		[SerializeField] private float _value;

		public override void Register(ref GameEntity entity) => entity.AddRadius(_value);
	}
}