﻿using System.Collections.Generic;


using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class UseCraneSystem : ReactiveSystem<GameEntity>
	{
		public UseCraneSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseDown, Crane));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> cranes) => cranes.ForEach(Use, @if: EnoughWater);

		private static bool EnoughWater(GameEntity crane) => crane.IsResourceEnough();

		private static void Use(GameEntity crane) => crane.isUsed = true;
	}
}