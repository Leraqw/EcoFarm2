using Code.Utils.Extensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.ViewListeners.UI
{
	public class GoalCompletedView : BaseViewListener, IGoalCompletedListener
	{
		[SerializeField] private Image _image;
		[SerializeField] private TextMeshProUGUI _textMesh;

		protected override void AddListener(GameEntity entity) => entity.AddGoalCompletedListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.isGoalCompleted;

		protected override void UpdateValue(GameEntity entity) => OnGoalCompleted(entity);

		public void OnGoalCompleted(GameEntity entity)
		{
			const float translucent = 0.5f;
			_image.color = _image.color.SetAlpha(translucent);
			_textMesh.color = _textMesh.color.SetAlpha(translucent);
		}
	}
}