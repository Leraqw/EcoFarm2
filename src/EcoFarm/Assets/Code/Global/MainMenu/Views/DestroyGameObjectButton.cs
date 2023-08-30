using Entitas.VisualDebugging.Unity;
using UnityEngine;

namespace EcoFarm
{
    public class DestroyGameObjectButton : BaseButtonClickReceiver
    {
        [SerializeField] private GameObject _gameObject;
        
        protected override void OnButtonClick() => _gameObject.gameObject.DestroyGameObject();
    }
}