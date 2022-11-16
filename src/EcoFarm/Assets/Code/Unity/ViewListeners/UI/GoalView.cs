using System;
using Code.Data.ToUnity;
using Code.ECS.Systems.Watering.Bucket;
using EcoFarmDataModule;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.ViewListeners.UI
{
	public class GoalView : BaseViewListener, IGoalListener
	{
		[SerializeField] private Image _image;
		[SerializeField] private TextMeshProUGUI _textMesh;

		private string _targetValue;
		private string _currentValue;

		private SpriteSheet ResourceAssociations
			=> Contexts.sharedInstance.GetConfiguration().Resource.Associations;

		protected override void AddListener(GameEntity entity) => entity.AddGoalListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasGoal;

		protected override void UpdateValue(GameEntity entity) => OnGoal(entity, entity.goal);

		public void OnGoal(GameEntity entity, Goal value)
		{
			_image.sprite = SpriteForGoal(entity);
			_targetValue = value.TargetQuantity.ToString();
			_currentValue = entity.currentQuantity.Value.ToString();
			_textMesh.text = $"{_currentValue} / {_targetValue}";
		}

		private Sprite SpriteForGoal(GameEntity entity)
			=> entity.hasProduct
				? ResourceAssociations.Dictionary[entity.product.Value.Title]
				: throw new NotImplementedException("No sprite for GoalByResource");
	}
}