// ReSharper disable CheckNamespace - namespace частей parital классов должен сопадать
using UnityEngine;

public sealed partial class GameEntity
{
	public override string ToString() => isTree ? "Tree" : base.ToString();

	public Vector2 SpawnPosition
	{
		get
		{
			Vector2 value = hasSpawnPosition ? spawnPosition.Value : Vector3.zero;
			RemoveSpawnPosition();
			return value;
		}
	}
}