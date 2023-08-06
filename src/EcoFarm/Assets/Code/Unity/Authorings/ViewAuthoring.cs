using UnityEngine;

namespace EcoFarm
{
	public class ViewAuthoring : RegistrarBase
	{
		[SerializeField] private GameObject _value;

		public override void Register(ref GameEntity entity) => entity.AddView(_value);
	}
}