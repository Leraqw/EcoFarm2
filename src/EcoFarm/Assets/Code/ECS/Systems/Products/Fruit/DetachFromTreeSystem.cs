﻿using System.Collections.Generic;

using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class DetachFromTreeSystem : ReactiveSystem<GameEntity>
	{
		public DetachFromTreeSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Collected, AttachedTo));

		protected override bool Filter(GameEntity entity) => entity.hasAttachedTo;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Detach);

		private static void Detach(GameEntity entity) => entity.Do((e) => e.RemoveAttachedTo());
	}
}