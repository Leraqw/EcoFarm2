using Code.ECS.Components.ComplexComponentTypes;
using TMPro;
using UnityEngine;

namespace Code.Unity.ViewListeners.UI
{
	public class ApplesInInventoryView : BaseViewListener, IInventoryItemListener
	{
		[SerializeField] private TextMeshProUGUI _text;

		protected override void AddListener(GameEntity entity) => entity.AddInventoryItemListener(this);
		protected override bool HasComponent(GameEntity entity) => entity.hasInventoryItem;

		protected override void UpdateValue(GameEntity entity) => OnInventoryItem(entity, entity.inventoryItem);

		public void OnInventoryItem(GameEntity entity, Item value) 
			=> _text.text = entity.inventoryItem.Value.Count.ToString();
	}
}