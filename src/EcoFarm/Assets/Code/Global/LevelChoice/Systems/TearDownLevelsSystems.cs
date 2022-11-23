using Code.Utils.Extensions;
using Entitas;

namespace Code.Global.LevelChoice.Systems
{
	public class TearDownLevelsSystems : ITearDownSystem
	{
		private readonly Contexts _contexts;

		public TearDownLevelsSystems(Contexts contexts) => _contexts = contexts;

		public void TearDown()
			=> _contexts.player.GetEntities(PlayerMatcher.LevelRelatedEntity).ForEach((e) => e.Destroy());
	}
}