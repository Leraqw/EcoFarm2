using System.Collections.Generic;
using Code.Services.Interfaces;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.View
{
	public sealed class LoadRequiredSpriteSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public LoadRequiredSpriteSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IResourcesService ResourcesService => _contexts.services.resourcesService.Value;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(RequireSprite);

		protected override bool Filter(GameEntity entity) => entity.hasRequireSprite;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Load);

		private void Load(GameEntity entity) 
			=> entity.ReplaceSprite(ResourcesService.LoadSprite(entity.requireSprite.Value));
	}
}