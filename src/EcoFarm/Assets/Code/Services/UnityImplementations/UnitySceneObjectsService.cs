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

		public IEnumerable<Vector2> TreeSpawnPositions => _treesSpawnPositions.Select((t) => (Vector2)t.position);
	}
}