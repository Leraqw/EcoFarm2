using Entitas;
using UnityEngine;

namespace EcoFarm
{
	public sealed class RotateSpinnersSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public RotateSpinnersSystem(Contexts contexts) => _entities = contexts.game.GetGroup(GameMatcher.Spinner);

		public void Execute()
		{
			foreach (var e in _entities)
			{
				e.ReplaceRotation(e.rotation.Value + e.rotationSpeed.Value * Time.fixedDeltaTime * 10);
				
				if (e.rotation.Value % 360 == 0)
				{
					e.ReplaceRotation(0f);
				}
			}
		}
	}
}