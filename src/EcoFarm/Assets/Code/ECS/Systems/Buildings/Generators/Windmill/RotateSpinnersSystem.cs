using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Buildings.Generators.Windmill
{
	public sealed class RotateSpinnersSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public RotateSpinnersSystem(Contexts contexts) => _entities = contexts.game.GetGroup(GameMatcher.Spinner);

		public void Execute()
		{
			foreach (var e in _entities)
			{
				e.ReplaceRotation(e.rotation + e.rotationSpeed * Time.deltaTime);
			}
		}
	}
}