
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code
{
	public class GoalCompletedView : BaseViewListener, IGoalCompletedListener
	{
		[SerializeField] private float _completedGoalOpacity = 0.5f;
		[SerializeField] private Image _image;
		[SerializeField] private TextMeshProUGUI _textMesh;
		[SerializeField] private GameObject _checkmark;

		protected override void AddListener(GameEntity entity) => entity.AddGoalCompletedListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.isGoalCompleted;

		protected override void UpdateValue(GameEntity entity) => OnGoalCompleted(entity);

		public void OnGoalCompleted(GameEntity entity)
		{
			_image.color = _image.color.SetAlpha(_completedGoalOpacity);
			_textMesh.color = _textMesh.color.SetAlpha(_completedGoalOpacity);
			
			_checkmark.SetActive(true);
		}
	}
}