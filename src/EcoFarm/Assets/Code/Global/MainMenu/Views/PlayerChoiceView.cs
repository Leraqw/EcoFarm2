using UnityEngine;

namespace EcoFarm
{
    public class PlayerChoiceView : BaseViewListener, IActivateListener
    {
        public void OnActivate(GameEntity entity, bool value)
        {
            Debug.Log($"entity: {entity.debugName.Value} is {value}");
            Debug.Log($"entity: {entity.view.Value}");
            entity.view.Value.SetActive(true);
        }

        protected override void AddListener(GameEntity entity) => entity.AddActivateListener(this);

        protected override bool HasComponent(GameEntity entity) => entity.hasActivate;

        protected override void UpdateValue(GameEntity entity) => OnActivate(entity, entity.activate.Value);
    }
}