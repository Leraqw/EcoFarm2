﻿using System.Collections.Generic;

using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class ConsumeUsedResourcesSystem : ReactiveSystem<GameEntity>
	{
		public ConsumeUsedResourcesSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Used);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Consume);

		private void Consume(GameEntity entity) => entity.Consume();
	}
}