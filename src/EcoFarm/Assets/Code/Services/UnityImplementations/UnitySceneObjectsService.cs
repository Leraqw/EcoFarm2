using System;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class UnitySceneObjectsService : ISceneObjectsService
	{
		[SerializeField] private Transform _debugTreeSpawnPosition;
		
		public Transform DebugTreeSpawnPosition => _debugTreeSpawnPosition;
	}
}