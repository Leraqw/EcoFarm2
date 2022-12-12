using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using UnityEngine;
using Xunit;

public class TreeWateringTests
{
	private GameEntity _tree;
	private GameEntity _bucket;
	private GameContext _context;

	public TreeWateringTests()
	{
		_context = new GameContext();
		_tree = InitializeTree(_context);
		_bucket = InitializeBucket(_context);
	}

	private GameEntity InitializeTree(GameContext context)
	{
		var entity = context.CreateEntity();
		entity.Do((e) => e.AddDebugName("Tree"))
		     .Do((e) => e.MakeAttachable())
		     .Do((e) => e.AddSpawnPosition(e.requireTreeOnPosition))
		     .Do((e) => e.isFruitful = true)
		     .Do((e) => e.RemoveRequireTreeOnPosition());
		return entity;
	}

	private GameEntity InitializeBucket(GameContext context)
	{
		var entity = context.CreateEntity();
		entity.AddRadius(2);
		entity.AddPosition(Vector2.zero);
		return entity;
	}

	[Fact]
	public void BucketDroppedNearTree()
	{
		
	}
}