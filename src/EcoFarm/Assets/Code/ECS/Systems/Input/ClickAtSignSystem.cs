using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class ClickAtSignSystem : ReactiveSystem<GameEntity>
	{
		private readonly IUiService _uiService;

		public ClickAtSignSystem(Contexts contexts, IUiService uiService)
			: base(contexts.game)
		{
			_uiService = uiService;
		}

		private IWindowsCollection Windows => _uiService.Windows;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseDown, Sign));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(OpenWindow);

		private void OpenWindow(GameEntity click) => Windows.Build.Listener.Entity
		                                                    .Do((e) => e.ReplacePosition(click.position.Value))
		                                                    .Do((e) => e.isPreparationInProcess = true);
	}
}