using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class InitializeBuildWindowSystem : IInitializeSystem
	{
		private readonly IUiService _uiService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public InitializeBuildWindowSystem
		(
			IUiService uiService,
			GameEntity.Factory gameEntityFactory
		)
		{
			_uiService = uiService;
			_gameEntityFactory = gameEntityFactory;
		}

		public void Initialize()
			=> _gameEntityFactory.Create()
			            .Do((e) => e.AddDebugName("BuildWindow"))
			            .Do((e) => e.AddActivate(false))
			            .Do((e) => e.AddView(_uiService.Windows.Build.gameObject))
			            .Do((e) => e.AddBuildWindow(_uiService.Windows.Build))
			            .Do((e) => e.MakeAttachable())
			            .Do((e) => e.isRequirePreparation = true);
	}
}