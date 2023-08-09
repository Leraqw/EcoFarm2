using Entitas;

namespace EcoFarm
{
	public sealed class LoadPlayersSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public LoadPlayersSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize() => ServicesMediator.DataProvider.Players.ForEach(ToEntity);

		private void ToEntity(Player player)
		{
			var e = _contexts.player.CreateEntity();
			e.isPlayer = true;
			e.AddNickname(player.Nickname);
			e.AddCompletedLevelsCount(player.CompletedLevelsCount);
			e.AddSessionResult(SessionResult.None);
		}
	}
}