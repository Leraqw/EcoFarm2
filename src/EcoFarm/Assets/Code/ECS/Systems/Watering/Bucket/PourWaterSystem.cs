using System.Collections.Generic;
using DesperateDevs.Logging;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Watering.Bucket
{
	public sealed class PourWaterSystem : ReactiveSystem<GameEntity>
	{
		public PourWaterSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseUp, Filled));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(PourOut);

		private static void PourOut(GameEntity entity) => entity.isFilled = false;
	}
}