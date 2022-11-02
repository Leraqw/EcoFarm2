using System.Collections.Generic;
using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface ISpawnPointsService
	{
		IEnumerable<Vector2> Trees { get; }
		Vector2 Warehouse { get; }
		Vector2 Crane { get; }
	}
}