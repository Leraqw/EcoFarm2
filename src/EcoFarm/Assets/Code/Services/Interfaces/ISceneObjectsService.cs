using System.Collections.Generic;
using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface ISceneObjectsService
	{
		IEnumerable<Vector2> TreeSpawnPositions { get; }
		Vector2 WarehouseSpawnPosition { get; }
		Vector2 CraneSpawnPosition { get; }
	}
}