using System.Collections.Generic;

using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class ResetNormalScaleSystem : ReactiveSystem<GameEntity>
	{
		public ResetNormalScaleSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Working.Removed());

		protected override bool Filter(GameEntity entity) => entity.isWorking == false && entity.hasSpriteHigh;

		protected override void Execute(List<GameEntity> entites)
		{
			foreach (var e in entites)
			{
				e.ReplaceSpriteHigh(Constants.SpriteHigh.Normal);
			}
		}
	}
}