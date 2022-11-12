using System;
using Code.Data.ToUnity;
using EcoFarmDataModule;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.ViewListeners.UI
{
	public class GoalListener : BaseViewListener, IGoalListener
	{
		[SerializeField] private Image _image;
		[SerializeField] private TextMeshProUGUI _textMesh;
		[SerializeField] private AssociationsCollection _associations;

		private string _targetValue;
		private string _currentValue;

		protected override void AddListener(GameEntity entity) => entity.AddGoalListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasGoal;

		protected override void UpdateValue(GameEntity entity) => OnGoal(entity, entity.goal);

		public void OnGoal(GameEntity entity, Goal value)
		{
			_image.sprite = SpriteForGoal(entity);
			_targetValue = value.TargetQuantity.ToString();
			_currentValue = 0.ToString();
			_textMesh.text = $"{_currentValue} / {_targetValue}";
		}

		private Sprite SpriteForGoal(GameEntity entity)
			=> entity.hasProduct
				? _associations.Dictionary[entity.product.Value.Title]
				: throw new NotImplementedException("No sprite for GoalByResource");
	}
}