using System.Collections.Generic;

using Entitas;
using static System.Globalization.CultureInfo;
using static GameMatcher;

namespace EcoFarm
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
			=> _sliderValueViews.ForEach((view) => Update(view, slider.sliderValue.Value));

		private void Update(GameEntity textMesh, float value) => textMesh.ReplaceText(Format(textMesh, value));

		private static string Format(GameEntity view, float value) => Scale(view, value).ToString(InvariantCulture);

		private static float Scale(GameEntity view, float value) => value * view.sellCoefficient.Value;
	}
}