
using Entitas;

namespace Code
{
	public sealed class DestroyAllGameEntitiesSystem : ITearDownSystem
	{
		private readonly Contexts _contexts;

		public DestroyAllGameEntitiesSystem(Contexts contexts) => _contexts = contexts;

		public void TearDown() 
			=> _contexts.game.GetEntities().ForEach((e) => e.Destroy());
	}
}