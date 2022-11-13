using Code.Utils.Extensions;
using Entitas;
using static Code.PlayerContext.CustomTypes.SessionResult;

namespace Code.PlayerContext.Systems
{
	public class InitializePlayerContextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializePlayerContextSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize() => _contexts.player
		                                     .CreateEntity()
		                                     .Do((e) => e.isPlayer = true)
		                                     .Do((e) => e.AddSessionResult(None))
		                                     .Do((e) => e.AddName("Test Player"));
	}
}