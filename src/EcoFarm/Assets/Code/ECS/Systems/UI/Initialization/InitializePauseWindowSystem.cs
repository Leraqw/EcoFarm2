using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class InitializePauseWindowSystem : IInitializeSystem
	{
		private readonly IUiService _uiService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public InitializePauseWindowSystem
		(
			Contexts contexts,
			IUiService uiService,
			GameEntity.Factory gameEntityFactory
		)
		{
			_uiService = uiService;
			_gameEntityFactory = gameEntityFactory;
		}

		public void Initialize()
			=> _gameEntityFactory.Create()
			            .Do((e) => e.AddDebugName("PauseWindow"))
			            .Do((e) => e.AddActivate(false))
			            .Do((e) => e.AddView(_uiService.Windows.Pause))
			            .Do((e) => e.MakeAttachable());
	}
}