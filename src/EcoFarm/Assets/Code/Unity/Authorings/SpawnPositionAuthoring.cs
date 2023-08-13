using UnityEngine;

namespace EcoFarm
{
	public class SpawnPositionAuthoring : AuthoringBase
	{
		[SerializeField] private Transform _transform;

		public override void Register(ref GameEntity entity) => entity.AddSpawnPosition(_transform.position);
	}
}