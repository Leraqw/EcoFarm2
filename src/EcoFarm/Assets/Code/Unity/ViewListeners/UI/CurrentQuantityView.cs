using TMPro;
using UnityEngine;

namespace EcoFarm
{
	public class CurrentQuantityView : BaseViewListener, ICurrentQuantityListener
	{
		[SerializeField] private TextMeshProUGUI _textMesh;

		protected override void AddListener(GameEntity entity) => entity.AddCurrentQuantityListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasCurrentQuantity;

		protected override void UpdateValue(GameEntity entity) => OnCurrentQuantity(entity, entity.currentQuantity.Value);

		public void OnCurrentQuantity(GameEntity entity, int value) 
			=> _textMesh.text = $"{value} / {((GoalByDevObject)entity.goal.Value).TargetQuantity}";
	}
}