
using TMPro;
using UnityEngine;

namespace Code
{
	public class ApplesInInventoryView : BaseViewListener, IInventoryItemListener
	{
		[SerializeField] private TextMeshProUGUI _text;

		protected override void AddListener(GameEntity entity) => entity.AddInventoryItemListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasInventoryItem;

		protected override void UpdateValue(GameEntity entity) => OnInventoryItem(entity, entity.inventoryItem);

		public void OnInventoryItem(GameEntity entity, Item value) => _text.text = value.Count.ToString();
	}
}