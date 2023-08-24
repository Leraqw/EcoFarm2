using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class CheckTreeOverWateringSystem : ReactiveSystem<GameEntity>
	{
		private readonly IConfigurationService _configurationService;

		public CheckTreeOverWateringSystem(GameContext context, IConfigurationService configurationService)
			: base(context)
			=> _configurationService = configurationService;

		private int MaxWatering => _configurationService.Balance.Tree.MaxWatering;

		private Sprite TreeRottenSprite => _configurationService.Resource.Sprite.Tree.Rotten;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Watered);

		protected override bool Filter(GameEntity entity) => entity.hasWatering;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkAsRotten, @if: IsOverWatered);

		private bool IsOverWatered(GameEntity entity) => entity.watering.Value > MaxWatering;

		private void MarkAsRotten(GameEntity entity) => entity.TreeIsDead(TreeRottenSprite);
	}
}