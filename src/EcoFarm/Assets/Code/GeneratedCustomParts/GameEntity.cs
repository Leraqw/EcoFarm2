// ReSharper disable CheckNamespace - parts of classes suppose to de in same namespace as original class
using UnityEngine;

public sealed partial class GameEntity
{
	public override string ToString() => isTree ? "Tree" : base.ToString();

	public Vector2 SpawnPositionOnce
	{
		get
		{
			Vector2 value;
			if (hasSpawnPosition)
			{
				value = spawnPosition.Value;
				RemoveSpawnPosition();
			}
			else
			{
				value = Vector3.zero;
			}

			return value;
		}
	}

	public void PerformRequiredView(GameObject gameObject)
	{
		AddView(gameObject);
		RemoveRequireView();
	}
}