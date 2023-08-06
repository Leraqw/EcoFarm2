using Entitas;
using UnityEngine;
using static EcoFarm.Constants.SpriteHigh;
using static GameMatcher;

namespace EcoFarm
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
				ChangeHighBySinusoid(e);
			}
		}

		private static void ChangeHighBySinusoid(GameEntity e)
		{
			const float delta = 0.1f;
			const int timeScale = 10;
			e.ReplaceSpriteHigh(Normal + Mathf.Sin(Time.time * timeScale) * delta);
		}
	}
}