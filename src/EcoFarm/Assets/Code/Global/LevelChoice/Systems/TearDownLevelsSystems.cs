
using Entitas;

namespace Code
{
	public class TearDownLevelsSystems : ITearDownSystem
	{
		private readonly Contexts _contexts;

		public TearDownLevelsSystems(Contexts contexts) => _contexts = contexts;

		public void TearDown()
			=> _contexts.player.GetEntities(PlayerMatcher.LevelRelatedEntity).ForEach((e) => e.Destroy());
	}
}