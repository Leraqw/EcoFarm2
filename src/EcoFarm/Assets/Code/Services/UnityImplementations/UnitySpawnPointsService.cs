using System;
using System.Collections.Generic;
using System.Linq;
using Code.Services.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class UnitySpawnPointsService : ISpawnPointsService
	{
		[FormerlySerializedAs("_treesSpawnPositions")] [SerializeField] private List<Transform> _trees;
		[FormerlySerializedAs("_warehouseSpawnPosition")] [SerializeField] private Transform _warehouse;
		[FormerlySerializedAs("_craneSpawnPosition")] [SerializeField] private Transform _crane;

		public IEnumerable<Vector2> Trees => _trees.Select((t) => (Vector2)t.position);
		public Vector2 Warehouse => _warehouse.position;
		public Vector2 Crane => _crane.position;
	}
}