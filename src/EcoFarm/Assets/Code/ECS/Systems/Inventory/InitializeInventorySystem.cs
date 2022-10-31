﻿using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Inventory
{
	public sealed class InitializeInventorySystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeInventorySystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.isInventory = true)
			            .Do((e) => e.AddCoinsCount(0))
			            .Do((e) => e.AddInventoryItem(("Apples", 0)));
	}
}