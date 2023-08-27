using Entitas;
using Zenject;
using static PlayerMatcher;

namespace EcoFarm
{
	public class TearDownLevelsSystems : ITearDownSystem
	{
		private readonly Contexts _contexts;

		[Inject] public TearDownLevelsSystems(Contexts contexts) => _contexts = contexts;

		public void TearDown() => _contexts.player.GetEntities(LevelRelatedEntity).DestroyAll();
	}
}