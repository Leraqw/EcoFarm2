using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class SpawnDroughtTimerSystem : IInitializeSystem
	{
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public SpawnDroughtTimerSystem(GameEntity.Factory gameEntityFactory)
			=> _gameEntityFactory = gameEntityFactory;

		public void Initialize()
		{
			var e = _gameEntityFactory.Create();
			e.AddDebugName("DroughtTimer");
			e.isDroughtTimer = true;
			e.ResetDroughtTimer();
		}
	}
}