using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.EcoResources.Water
{
	public sealed class UseCraneSystem : ReactiveSystem<GameEntity>
	{
		public UseCraneSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseDown, Crane));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> cranes) => cranes.ForEach(Use, @if: HasWater);

		private static bool HasWater(GameEntity crane) => crane.IsResourceExhausted() == false;

		private static void Use(GameEntity crane) => crane.isUsed = true;
	}
}