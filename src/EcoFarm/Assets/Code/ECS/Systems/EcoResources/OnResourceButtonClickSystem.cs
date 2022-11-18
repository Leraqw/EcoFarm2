using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.EcoResources
{
	public sealed class OnResourceButtonClickSystem : ReactiveSystem<GameEntity>
	{
		public OnResourceButtonClickSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(ProgressBar, MouseDown));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Handle);

		private void Handle(GameEntity resource) => resource.UpdateResourceCurrentValue(resource.progressBar.Value.Max);
	}
}