using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
    public class BuildView : BaseViewListener, IBuildingListener
    {
        [SerializeField] private TextMeshProUGUI _titleTextMesh;
        [SerializeField] private TextMeshProUGUI _descriptionTextMesh;
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _priceTextMesh;

        protected override void AddListener(GameEntity entity) => entity.AddBuildingListener(this);

        protected override bool HasComponent(GameEntity entity) => entity.hasBuilding;

        protected override void UpdateValue(GameEntity entity) => OnBuilding(entity, entity.building.Value);

        public void OnBuilding(GameEntity entity, Building value)
        {
            _titleTextMesh.text = GetItemTitle(value.Title);
            _descriptionTextMesh.text = value.Description;
            _priceTextMesh.text = value.Price.ToString();
            _image.sprite = value.Sprite;
        }

        private string GetItemTitle(ItemName itemName) =>
            itemName switch
            {
                ItemName.CoinItem => "Монета",
                ItemName.Windmill => "Ветрогенератор",
                ItemName.WaterCleaner => "Водоочистная станция",
                ItemName.Electricity => "Электричество",
                ItemName.Water => "Вода",
                _ => string.Empty
            };
    }
}