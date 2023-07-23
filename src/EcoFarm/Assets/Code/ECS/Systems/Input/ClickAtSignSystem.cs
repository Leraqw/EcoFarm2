using System.Collections.Generic;


using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class ClickAtSignSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public ClickAtSignSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IWindowsCollection Windows => _contexts.services.uiService.Value.Windows;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseDown, Sign));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(OpenWindow);

		private void OpenWindow(GameEntity click) => Windows.Build.Listener.Entity
		                                                    .Do((e) => e.ReplacePosition(click.position.Value))
		                                                    .Do((e) => e.isPreparationInProcess = true);
	}
}