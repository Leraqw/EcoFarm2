
using Entitas;
using static EcoFarm.SessionResult;

namespace EcoFarm
{
	public class InitializePlayerContextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializePlayerContextSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize() => _contexts.player.Do(Load, @if: IsNotCreatedYet);

		private bool IsNotCreatedYet(PlayerContext arg) => _contexts.player.currentPlayerEntity == null;

		private static void Load(PlayerContext context)
		{
			context.CreateEntity()
			       .Do((e) => e.isPlayer = true)
			       .Do((e) => e.AddSessionResult(None))
			       .Do((e) => e.AddNickname("Test Player"));
		}
	}
}