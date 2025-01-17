﻿using System.Collections.Generic;


using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class PermanentProduceResourceSystem : ReactiveSystem<GameEntity>
	{
		public PermanentProduceResourceSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(GameMatcher.Generator, EfficiencyCoefficient, PermanentGenerator, DurationUp));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(ProducePerSecond);

		private static void ProducePerSecond(GameEntity generator)
			=> generator
			   .Do((g) => g.Produce())
			   .Do((g) => g.ReplaceDuration(1))
		/**/;
	}
}