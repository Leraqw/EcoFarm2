using Entitas;
using UnityEngine;

namespace Code.Global.LevelChoice.Systems
{
	public sealed class LevelsInitializationSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public LevelsInitializationSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
		{
			Debug.Log("Levels Choice opened");

			_contexts.player.CreateEntity()
			         .isLevelRelatedEntity = true;
		}
	}
}