using System;
using System.Collections.Generic;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class UnitySceneObjectsService : ISceneObjectsService
	{
		[SerializeField] private List<Transform>  _treesSpawnPositions;
		
		public List<Transform> TreeSpawnPositions => _treesSpawnPositions;
	}
}