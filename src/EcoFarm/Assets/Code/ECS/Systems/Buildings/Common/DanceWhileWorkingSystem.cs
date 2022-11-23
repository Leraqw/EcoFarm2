using Entitas;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants.SpriteHigh;
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
				// Change high by sinusoid
				var delta = 0.1f;
				var timeScale = 10;
				e.ReplaceSpriteHigh(Normal + Mathf.Sin(Time.time * timeScale) * delta);
			}
		}
	}
}