using Entitas;

namespace EcoFarm
{
	public sealed class LoadPlayersSystem : IInitializeSystem
	{
		private readonly PlayerEntity.Factory _playerEntityFactory;

		public LoadPlayersSystem(PlayerEntity.Factory playerEntityFactory)
			=> _playerEntityFactory = playerEntityFactory;

		public void Initialize()
		{
			var e = _playerEntityFactory.Create();
			e.isPlayer = true;
			e.AddSessionResult(SessionResult.None);
		}
	}
}