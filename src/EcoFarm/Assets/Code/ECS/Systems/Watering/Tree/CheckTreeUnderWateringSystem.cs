using System.Collections.Generic;
using Code.ECS.Systems.Watering.Bucket;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Watering.Tree
{
	public sealed class CheckTreeUnderWateringSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public CheckTreeUnderWateringSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private int MinWatering => _contexts.GetConfiguration().Balance.Tree.MinWatering;

		private Sprite TreeDrySprite => _contexts.GetConfiguration().Resource.Sprite.Tree.Dry;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Watered);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkAsRotten, @if: IsOverWatered);

		private bool IsOverWatered(GameEntity entity) => entity.watering < MinWatering;

		private void MarkAsRotten(GameEntity entity)
			=> entity.Do((e) => e.ReplaceWatering(MinWatering))
			         .Do((e) => e.AddSpriteToLoad(TreeDrySprite))
			         .Do((e) => e.isFruitful = false);
	}
}