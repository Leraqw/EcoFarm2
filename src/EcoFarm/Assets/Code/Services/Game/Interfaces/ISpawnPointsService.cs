using System.Collections.Generic;
using UnityEngine;

namespace Code.Services.Game.Interfaces
{
	public interface ISpawnPointsService
	{
		IEnumerable<Vector2> Trees { get; }
		IEnumerable<Vector2> Buildings { get; }
		Vector2 Warehouse { get; }
		Vector2 Crane { get; }
		Vector2 Bucket { get; }
	}
}