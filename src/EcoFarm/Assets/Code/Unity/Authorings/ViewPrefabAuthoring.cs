using UnityEngine;

namespace Code
{
	public class ViewPrefabAuthoring : RegistrarBase
	{
		[SerializeField] private GameObject _value;

		public override void Register(ref GameEntity entity) => entity.AddViewPrefab(_value);
	}
}