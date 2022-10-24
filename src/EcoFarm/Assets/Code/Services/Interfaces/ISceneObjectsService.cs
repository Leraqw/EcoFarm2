using System.Collections.Generic;
using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface ISceneObjectsService
	{
		List<Transform> TreeSpawnPositions { get; }
	}
}