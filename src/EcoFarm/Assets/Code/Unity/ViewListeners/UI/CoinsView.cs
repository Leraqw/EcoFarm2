using TMPro;
using UnityEngine;

namespace Code.Unity.ViewListeners.UI
{
	public class CoinsView : BaseViewListener, ICoinsCountListener
	{
		[SerializeField] private TextMeshProUGUI _text;

		protected override void AddListener(GameEntity entity) => entity.AddCoinsCountListener(this);
		protected override bool HasComponent(GameEntity entity) => entity.hasCoinsCount;

		protected override void UpdateValue(GameEntity entity) => OnCoinsCount(entity, entity.coinsCount);

		public void OnCoinsCount(GameEntity entity, int value) => _text.text = value.ToString();
	}
}