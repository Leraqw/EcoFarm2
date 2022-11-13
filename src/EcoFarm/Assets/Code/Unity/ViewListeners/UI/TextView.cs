using TMPro;
using UnityEngine;

namespace Code.Unity.ViewListeners.UI
{
	public class TextView : BaseViewListener, IGameTextListener, IPlayerTextListener
	{
		[SerializeField] private TextMeshProUGUI _text;

		protected override void AddListener(GameEntity entity) => entity.AddGameTextListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasText;

		protected override void UpdateValue(GameEntity entity) => SetText(entity.text.Value);

		public void OnText(GameEntity entity, string value) => SetText(value);
		
		public void OnText(PlayerEntity entity, string value) => SetText(value);

		private void SetText(string value) => _text.text = value;
	}
}