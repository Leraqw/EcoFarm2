using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace EcoFarm
{
    public abstract class UnityEventAdapter : MonoBehaviour
    {
        [FormerlySerializedAs("Button")] [SerializeField] protected Button _button;

        private void OnEnable() => _button.onClick.AddListener(OnButtonClick);

        private void OnDisable() => _button.onClick.RemoveListener(OnButtonClick);

        protected abstract void OnButtonClick();
    }
}