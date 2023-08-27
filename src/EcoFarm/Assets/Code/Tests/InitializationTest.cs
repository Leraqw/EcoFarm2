using EcoFarm;
using EcoFarm.Tests;
using FluentAssertions;
using NUnit.Framework;

public class InitializationTest
{
	private SpawnBucketSystem _system;
	private Contexts _contexts;

	[SetUp]
	public void SetUp()
	{
		_contexts = new Contexts();
		Setup.Services(_contexts);
		// _contexts.game.CreateEntity();
		// TODO: fix testes
		// _system = Create.SpawnBucketSystem();
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