using Code.Utils.StaticClasses;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Common
{
	public sealed class DanceWhileWorkingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public DanceWhileWorkingSystem(Contexts contexts)
		{
			_entities = contexts.game.GetGroup(Working);
		}

		public void Execute()
		{
			foreach (var e in _entities)
			{
				e.ReplaceSpriteHigh(e.spriteHigh + Constants.SpriteHighDelta);
			}
		}
	}
}