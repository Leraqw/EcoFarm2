using UnityEngine;

namespace EcoFarm
{
	public class DebugNameAuthoring : AuthoringBase
	{
		[SerializeField] private string _value;

		public override void Register(ref GameEntity entity) => entity.AddDebugName(_value);
	}
}