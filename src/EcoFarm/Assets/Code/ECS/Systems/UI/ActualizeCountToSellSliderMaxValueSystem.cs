using System.Collections.Generic;
using System.Linq;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class ActualizeCountToSellSliderMaxValueSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		private readonly IGroup<GameEntity> _sliders;

		public ActualizeCountToSellSliderMaxValueSystem(Contexts contexts)
			: base(contexts.game)
		{
			_sliders = contexts.game.GetGroup(SliderMaxValue);
			_contexts = contexts;
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(InventoryItem);

		protected override bool Filter(GameEntity entity) 
			=> true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Actualize);

		private bool HasSameFruitType(GameEntity item, GameEntity slider) => item.HasSameFruitType(slider);

		private void Actualize(GameEntity item)
		{
			
		}
	}
}