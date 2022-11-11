using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class ActualizeCountToSellSliderMaxValueSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _sliders;

		public ActualizeCountToSellSliderMaxValueSystem(Contexts contexts)
			: base(contexts.game)
			=> _sliders = contexts.game.GetGroup(SliderMaxValue);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(InventoryItem);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(ActualizeSliders);

		private void ActualizeSliders(GameEntity item)
			=> _sliders.ForEach((s) => Actualize(s, item), @if: item.IsSameFruit);

		private static void Actualize(GameEntity slider, GameEntity item)
			=> slider.ReplaceSliderMaxValue(item.inventoryItem.Value.Count);
	}
}