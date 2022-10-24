using System.Collections.Generic;
using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface ISceneObjectsService
	{
		IEnumerable<Vector2> TreeSpawnPositions { get; }
	}
}