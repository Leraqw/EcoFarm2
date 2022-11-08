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

		private Item FirstInventoryItem => _contexts.game.GetInventoryItems().First().inventoryItem.Value;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(PreparationInProcess, SellWindow));

		protected override bool Filter(GameEntity entity) => entity.isPrepared == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Prepare);

		private void Prepare(GameEntity window)
		{
			var sliders = _contexts.game
			                       .GetEntitiesWithAttachedTo(window.attachableIndex)
			                       .Where(IsSlider);

			sliders.ForEach(ActualizeValue);

			window.isPreparationInProcess = false;
			window.isPrepared = true;
		}

		private void ActualizeValue(GameEntity entity) => entity.sliderMaxValue.Value = FirstInventoryItem.Count;

		private bool IsSlider(GameEntity e) => e.hasSliderMaxValue;
	}
}