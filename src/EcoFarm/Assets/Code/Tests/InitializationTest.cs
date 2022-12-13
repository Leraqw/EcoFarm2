using Code.ECS.Systems.Watering.Bucket;
using Code.Tests;
using Entitas;
using FluentAssertions;
using NUnit.Framework;

public class InitializationTest
{
	private SpawnBucketSystem _system;
	private GameEntity _entity;
	private Contexts _contexts;

	[SetUp]
	public void SetUp()
	{
		_contexts = new Contexts();
		Setup.Services(_contexts);
		_entity = _contexts.game.CreateEntity();
		_system = Create.SpawnBucketSystem(_contexts);
	}

	[Test]
	public void WhenSpawnBucket_AndSystemInitialized_ThenShouldBeOneBucket()
	{
		// Arrange.

		// Act.
		_system.Initialize();

		// Assert.
		_contexts.game.GetGroup(GameMatcher.Bucket).count.Should().Be(1);
	}
}