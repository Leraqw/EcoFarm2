using EcoFarm;
using EcoFarm.Tests;
using NUnit.Framework;
using FluentAssertions;
using UnityEngine;

public class PickableTests
{
    private GameEntity _entity;
    private PickedToWarehouseSystem _system;

    [SetUp]
    public void SetUp()
    {
        var contexts = new Contexts();
        Setup.Services(contexts);
        _entity = contexts.game.CreateEntity();
        _system = Create.PickedToWarehouseSystem(contexts);
    }
    
    [Test]
    public void WhenPickable_AndPicked_ThenEntityShouldBeCollected()
    {
        // Arrange
        _entity.isPicked = true;
        _entity.AddPosition(Vector2.zero);
        
        // Act
        _system.Execute();
        
        // Assert
        _entity.isCollected.Should().BeTrue();
    }

    [Test]
    public void WhenPickable_AndNotPicked_ThenEntityShouldBeNotCollected()
    {
        // Arrange.
        _entity.isPicked = false;
        _entity.AddPosition(Vector2.zero);

        // Act
        _system.Execute();
        
        // Assert
        _entity.isCollected.Should().BeFalse();
    }
}
