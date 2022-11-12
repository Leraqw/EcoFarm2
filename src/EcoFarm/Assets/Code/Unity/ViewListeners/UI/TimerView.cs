using TMPro;
using UnityEngine;

namespace Code.Unity.ViewListeners.UI
{
	public class TimerView : BaseViewListener, IDurationListener
	{
		[SerializeField] private TextMeshProUGUI _textMesh;

		protected override void AddListener(GameEntity entity) => entity.AddDurationListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasDuration;

		protected override void UpdateValue(GameEntity entity) => OnDuration(entity, entity.duration);

		public void OnDuration(GameEntity entity, float value) => _textMesh.text = InMmSsFormat(value);

		private static string InMmSsFormat(float seconds) => $"{(int)seconds / 60:00}:{(int)seconds % 60:00}";
	}
}