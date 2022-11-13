using Code.Utils.Extensions;
using Entitas;
using static Code.Global.PlayerContext.CustomTypes.SessionResult;

namespace Code.Global.PlayerContext.Systems
{
	public class InitializePlayerContextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializePlayerContextSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize() => _contexts.player.Do(CreatePlayer, @if: IsNotCreatedYet);

		private bool IsNotCreatedYet(global::PlayerContext arg) => _contexts.player.playerEntity == null;

		private static void CreatePlayer(global::PlayerContext context)
			=> context.CreateEntity()
			          .Do((e) => e.isPlayer = true)
			          .Do((e) => e.AddSessionResult(None))
			          .Do((e) => e.AddName("Test Player"));
	}
}