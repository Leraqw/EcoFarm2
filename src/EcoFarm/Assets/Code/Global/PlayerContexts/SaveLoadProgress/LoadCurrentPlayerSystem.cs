using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class LoadCurrentPlayerSystem : IInitializeSystem
	{
		private readonly PlayerEntity.Factory _playerEntityFactory;

		[Inject]
		public LoadCurrentPlayerSystem(PlayerEntity.Factory playerEntityFactory)
			=> _playerEntityFactory = playerEntityFactory;

		public void Initialize()
		{
			var e = _playerEntityFactory.Create();
			e.isPlayer = true;
			e.isCurrentPlayer = true;
			e.AddSessionResult(SessionResult.None);
		}
	}
}