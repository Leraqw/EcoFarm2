using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public class SellButtonClickReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private SliderValueView _slider;

        protected override void OnButtonClick() => Context.sellDealEntity.AddCount(_slider.Value);
    }
}