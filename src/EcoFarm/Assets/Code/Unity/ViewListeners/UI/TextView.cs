using TMPro;
using UnityEngine;

namespace Code.Unity.ViewListeners.UI
{
	public class TextView : BaseViewListener, ITextListener
	{
		[SerializeField] private TextMeshProUGUI _text;

		protected override void AddListener(GameEntity entity) => entity.AddTextListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasText;

		protected override void UpdateValue(GameEntity entity) => OnText(entity, entity.text.Value);

		public void OnText(GameEntity entity, string value) => _text.text = value;
	}
}