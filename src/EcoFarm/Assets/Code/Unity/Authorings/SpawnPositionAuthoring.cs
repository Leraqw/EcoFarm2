using UnityEngine;

namespace EcoFarm
{
	public class SpawnPositionAuthoring : RegistrarBase
	{
		[SerializeField] private Transform _transform;

		public override void Register(ref GameEntity entity) => entity.AddSpawnPosition(_transform.position);
	}
}