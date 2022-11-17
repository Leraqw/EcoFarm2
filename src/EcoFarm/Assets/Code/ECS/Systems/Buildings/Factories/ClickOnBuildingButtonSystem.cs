using System.Collections.Generic;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Factories
{
	public sealed class ClickOnBuildingButtonSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		private readonly IGroup<GameEntity> _signs;

		public ClickOnBuildingButtonSystem(Contexts contexts)
			: base(contexts.game)
		{
			_contexts = contexts;
			_signs = contexts.game.GetGroup(Sign);
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(UiElement, MouseDown, Building));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Spawn);

		private void Spawn(GameEntity button)
			=> _signs.ForEach(Replace, @if: button.HasSamePosition);

		private void Replace(GameEntity sign)
			=> sign
			   .Do((e) => e.RemoveView())
			   .Do((e) => e.ReplaceViewPrefab(Resource.Prefab.Factory));

		private IResourceConfig Resource => _contexts.services.configurationService.Value.Resource;
	}
}