using System.Collections.Generic;
using Code.ECS.Systems.Watering.Bucket;
using Entitas;
using Code.Utils.Extensions;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Watering.Tree
{
	public sealed class CheckTreeOverWateringSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public CheckTreeOverWateringSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private int MaxWatering => _contexts.GetConfiguration().Balance.Tree.MaxWatering;

		private Sprite TreeRottenSprite => _contexts.GetConfiguration().Resource.Sprite.Tree.Rotten;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Watered);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkAsRotten, @if: IsOverWatered);

		private bool IsOverWatered(GameEntity entity) => entity.watering > MaxWatering;

		private void MarkAsRotten(GameEntity entity)
			=> entity.Do((e) => e.ReplaceWatering(MaxWatering))
			         .Do((e) => e.AddSpriteToLoad(TreeRottenSprite));
	}
}