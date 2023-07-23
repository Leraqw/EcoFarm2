using System.Collections.Generic;



using Entitas;
using UnityEngine;

namespace Code
{
	public sealed class CheckTreeUnderWateringSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public CheckTreeUnderWateringSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private Sprite TreeDrySprite => _contexts.GetConfiguration().Resource.Sprite.Tree.Dry;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Watering);

		private int MinWatering => _contexts.GetConfiguration().Balance.Tree.MinWatering;

		protected override bool Filter(GameEntity entity) => entity.hasWatering;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkAsDry, @if: IsOverWatered);

		private bool IsOverWatered(GameEntity entity) => entity.watering.Value <= MinWatering;

		private void MarkAsDry(GameEntity entity)
			=> entity.TreeIsDead(TreeDrySprite);
	}
}