using Entitas;

namespace Code.Global.LevelChoice.Systems
{
	public sealed class LevelsInitializationSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public LevelsInitializationSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
		{
			var e = _contexts.player.CreateEntity();
			e.isLevelRelatedEntity = true;
		}
	}
}