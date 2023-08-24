using System.Collections.Generic;
using Entitas;
using UnityEngine;
using Zenject;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class SyncSpriteWithBucketStateSystem : ReactiveSystem<GameEntity>
	{
		private readonly IConfigurationService _configuration;

		[Inject]
		public SyncSpriteWithBucketStateSystem(Contexts contexts, IConfigurationService configuration)
			: base(contexts.game)
			=> _configuration = configuration;

		private ISpriteConfig Sprite => _configuration.Resource.Sprite;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Filled.AddedOrRemoved());

		protected override bool Filter(GameEntity entity) => entity.hasSprite && entity.hasRequireSprite == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Sync);

		private void Sync(GameEntity entity) => entity.AddSpriteToLoad(GetActualBuketSprite(entity));

		private Sprite GetActualBuketSprite(GameEntity entity)
			=> entity.isFilled ? Sprite.Bucket.Filled : Sprite.Bucket.Empty;
	}
}