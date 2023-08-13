using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
	public class GoalView : BaseViewListener, IGoalListener
	{
		[SerializeField] private Image _image;
		[SerializeField] private TextMeshProUGUI _textMesh;

		private string _targetValue;
		private string _currentValue;

		protected override void AddListener(GameEntity entity) => entity.AddGoalListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasGoal;

		protected override void UpdateValue(GameEntity entity) => OnGoal(entity, entity.goal.Value);

		public void OnGoal(GameEntity entity, Goal value)
		{
			if (value is not GoalByDevObject goal)
				throw new NotImplementedException();

			_image.sprite = goal.DevObject.Sprite;
			_targetValue = goal.TargetQuantity.ToString();
			_currentValue = entity.currentQuantity.Value.ToString();
			_textMesh.text = $"{_currentValue} / {_targetValue}";
		}
	}
}