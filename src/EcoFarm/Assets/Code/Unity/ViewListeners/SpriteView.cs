using UnityEngine;

namespace EcoFarm
{
    public class SpriteView : BaseViewListener, ISpriteListener
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        
        protected override void AddListener(GameEntity entity) => entity.AddSpriteListener(this);

        protected override bool HasComponent(GameEntity entity) => entity.hasSprite;

        protected override void UpdateValue(GameEntity entity) => OnSprite(entity, entity.sprite.Value);

        public void OnSprite(GameEntity entity, Sprite value) => _spriteRenderer.sprite = value;
    }
}