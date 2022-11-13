using System;
using System.Collections.Generic;
using System.Linq;
using Code.Services.Game.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class UnitySpawnPointsService : ISpawnPointsService
	{
		[SerializeField] private List<Transform> _trees;
		[SerializeField] private Transform _warehouse;
		[SerializeField] private Transform _crane;
		[SerializeField] private Transform _bucket;

		public IEnumerable<Vector2> Trees     => _trees.Select((t) => (Vector2)t.position);
		public Vector2              Warehouse => _warehouse.position;
		public Vector2              Crane     => _crane.position;
		public Vector2              Bucket    => _bucket.position;
	}
}