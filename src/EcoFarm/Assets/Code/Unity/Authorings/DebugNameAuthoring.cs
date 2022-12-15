using UnityEngine;

namespace Code
{
	public class DebugNameAuthoring : RegistrarBase
	{
		[SerializeField] private string _value;

		public override void Register(ref GameEntity entity) => entity.AddDebugName(_value);
	}
}