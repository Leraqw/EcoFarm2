using UnityEngine;

namespace EcoFarm
{
	public class ViewAuthoring : AuthoringBase
	{
		[SerializeField] private GameObject _value;

		public override void Register(ref GameEntity entity) => entity.AddView(_value);
	}
}