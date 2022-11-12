using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Level
{
	public sealed class DebugGameOverSystem : ReactiveSystem<GameEntity>
	{
		public DebugGameOverSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(DurationUp, LevelTimer));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites)
		{
			foreach (var _ in entites)
			{
				Debug.Log("Game Over");
			}
		}
	}
}