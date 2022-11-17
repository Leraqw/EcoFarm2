using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static System.Globalization.CultureInfo;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class OnSliderValueChangedSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _sliderValueViews;

		public OnSliderValueChangedSystem(Contexts contexts)
			: base(contexts.game)
			=> _sliderValueViews = contexts.game.GetGroup(AllOf(Text, SellCoefficient));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(SliderValue);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Sync);

		private void Sync(GameEntity slider)
			=> _sliderValueViews.ForEach((view) => Update(view, slider.sliderValue));

		private void Update(GameEntity view, float value) => view.ReplaceText(Scale(view, value));

		private static string Scale(GameEntity view, float value)
			=> (value * view.sellCoefficient).ToString(InvariantCulture);
	}
}