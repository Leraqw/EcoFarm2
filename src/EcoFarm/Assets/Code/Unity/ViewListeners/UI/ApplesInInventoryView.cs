
using TMPro;
using UnityEngine;

namespace EcoFarm
{
	public class ApplesInInventoryView : BaseViewListener, IInventoryItemListener
	{
		[SerializeField] private TextMeshProUGUI _text;

		protected override void AddListener(GameEntity entity) => entity.AddInventoryItemListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasInventoryItem;

		protected override void UpdateValue(GameEntity entity) => OnInventoryItem(entity, entity.inventoryItem.Value);

		public void OnInventoryItem(GameEntity entity, Item value) => _text.text = value.Count.ToString();
	}
}