
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code
{
	public sealed class DurationSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public DurationSystem(Contexts contexts)
			=> _entities = contexts.game.GetGroup(AllOf(Duration).NoneOf(DurationUp));

		public void Execute() => _entities.ForEach(Tick);

		private static void Tick(GameEntity entity) => entity.ReplaceDuration(entity.duration - Time.deltaTime);
	}
}