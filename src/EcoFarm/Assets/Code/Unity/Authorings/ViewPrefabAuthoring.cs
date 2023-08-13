using UnityEngine;

namespace EcoFarm
{
	public class ViewPrefabAuthoring : AuthoringBase
	{
		[SerializeField] private GameObject _value;

		public override void Register(ref GameEntity entity) => entity.AddViewPrefab(_value);
	}
}