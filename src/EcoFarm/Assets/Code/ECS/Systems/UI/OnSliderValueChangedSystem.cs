using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static System.Globalization.CultureInfo;
using static GameMatcher;

namespace EcoFarm
{
    public sealed class OnSliderValueChangedSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _sliderValueViews;

        public OnSliderValueChangedSystem(Contexts contexts)
            => _sliderValueViews = contexts.game.GetGroup(AllOf(Text, SellCoefficient));

        public void Execute() => Contexts.sharedInstance.game.GetEntities(SliderValue).ForEach(Sync);

        private void Sync(GameEntity slider)
            => _sliderValueViews.ForEach((view) => view.ReplaceText(Format(view, slider.sliderValue.Value)));

        private static string Format(GameEntity e, float value) => Scale(e, value).ToString(InvariantCulture);

        private static float Scale(GameEntity e, float value) => value * e.sellCoefficient.Value;
    }
}