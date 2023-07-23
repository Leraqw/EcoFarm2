using TMPro;
using UnityEngine;

namespace Code
{
	public class CoinsView : BaseViewListener, ICoinsCountListener
	{
		[SerializeField] private TextMeshProUGUI _text;

		protected override void AddListener(GameEntity entity) => entity.AddCoinsCountListener(this);
		protected override bool HasComponent(GameEntity entity) => entity.hasCoinsCount;

		protected override void UpdateValue(GameEntity entity) => OnCoinsCount(entity, entity.coinsCount.Value);

		public void OnCoinsCount(GameEntity entity, int value) => _text.text = value.ToString();
	}
}