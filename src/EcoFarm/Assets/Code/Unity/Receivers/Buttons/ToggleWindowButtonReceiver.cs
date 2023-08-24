using UnityEngine;

namespace EcoFarm
{
    public class ToggleWindowButtonReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private GameObject _window;
        [SerializeField] private bool _targetActivity;

        protected override void OnButtonClick() => _window.gameObject.SetActive(_targetActivity);
    }
}