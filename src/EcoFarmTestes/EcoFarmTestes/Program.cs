using Code.ECS.Systems.Warehouse;
using UnityEngine;
using Xunit;

namespace Testes;

public class PickedToWarehouseTests
{
	private readonly GameEntity _entity;
	private readonly PickedToWarehouseSystem _system;

	public PickedToWarehouseTests()
	{
		var contexts = new Contexts();
		_system = new PickedToWarehouseSystem(contexts);
		_entity = contexts.game.CreateEntity();
	}

	[Fact]
	public void SuccessPickedNotCollectedPickableEntity()
	{
		// Arrange
		_entity.isPicked = true;
		_entity.AddPosition(Vector2.zero);

		// Act
		_system.Execute();

		// Assert
		Assert.True(_entity.isCollected);
	}
}