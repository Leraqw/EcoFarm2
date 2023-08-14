using UnityEngine;

namespace EcoFarm
{
    public class HighlightView : BaseViewListener, IMaterialListener
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;

        protected override void AddListener(GameEntity entity) => entity.AddMaterialListener(this);

        protected override bool HasComponent(GameEntity entity) => entity.hasMaterial;

        protected override void UpdateValue(GameEntity entity) => OnMaterial(entity, entity.material.Value);

        public void OnMaterial(GameEntity entity, Material value) => _spriteRenderer.material = value;
    }
}