using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace EcoFarm
{
	public sealed class CheckTreeUnderWateringSystem : ReactiveSystem<GameEntity>
	{
		private readonly IConfigurationService _configurationService;

		public CheckTreeUnderWateringSystem(Contexts contexts, IConfigurationService configurationService)
			: base(contexts.game)
		{
			_configurationService = configurationService;
		}

		private Sprite TreeDrySprite => _configurationService.Resource.Sprite.Tree.Dry;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Watering);

		private int MinWatering => _configurationService.Balance.Tree.MinWatering;

		protected override bool Filter(GameEntity entity) => entity.hasWatering;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkAsDry, @if: IsOverWatered);

		private bool IsOverWatered(GameEntity entity) => entity.watering.Value <= MinWatering;

		private void MarkAsDry(GameEntity entity)
			=> entity.TreeIsDead(TreeDrySprite);
	}
}