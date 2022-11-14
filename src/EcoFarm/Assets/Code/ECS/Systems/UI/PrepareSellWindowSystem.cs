using System.Collections.Generic;
using System.Linq;
using Code.ECS.Components.ComplexComponentTypes;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class PrepareSellWindowSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public PrepareSellWindowSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(PreparationInProcess, SellWindow));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Prepare);

		private void Prepare(GameEntity window)
		{
			_contexts.game
			         .GetEntitiesWithAttachedTo(window.attachableIndex)
			         .Where(IsSlider)
			         .ForEach(ActualizeValue);

			window.isPreparationInProcess = false;
			window.isPrepared = true;
		}

		private void ActualizeValue(GameEntity slider)
			=> slider.ReplaceSliderMaxValue(ItemWithSameProduct(slider).Count);

		private Item ItemWithSameProduct(GameEntity slider) 
			=> _contexts.game.GetInventoryItems().First(slider.HasSameProduct).inventoryItem;

		private bool IsSlider(GameEntity e) => e.hasSliderMaxValue;
	}
}