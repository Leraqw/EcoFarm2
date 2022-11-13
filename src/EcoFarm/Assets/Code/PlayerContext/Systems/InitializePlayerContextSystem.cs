using Code.Utils.Extensions;
using Entitas;

namespace Code.PlayerContext.Systems
{
	public class InitializePlayerContextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializePlayerContextSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize() => _contexts.player
		                                     .CreateEntity()
		                                     .Do((e) => e.isPlayer = true)
		                                     .Do((e) => e.AddName("Test Player"));
	}
}