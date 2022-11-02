using System;
using System.Collections.Generic;
using System.Linq;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class UnitySceneObjectsService : ISceneObjectsService
	{
		[SerializeField] private List<Transform> _treesSpawnPositions;
		[SerializeField] private Transform _warehouseSpawnPosition;
		[SerializeField] private Transform _craneSpawnPosition;

		public IEnumerable<Vector2> TreeSpawnPositions => _treesSpawnPositions.Select((t) => (Vector2)t.position);
		public Vector2 WarehouseSpawnPosition => _warehouseSpawnPosition.position;
		public Vector2 CraneSpawnPosition => _craneSpawnPosition.position;
	}
}