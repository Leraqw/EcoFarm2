using UnityEngine;
using Zenject;
using static GameMatcher;

namespace EcoFarm
{
	public class PlayerChoiceEntityRegister : MonoBehaviour
	{
		[SerializeField] private GameObject _playerChoicePrefab;
		[SerializeField] private RectTransform _content;

		private GameEntity.Factory _gameEntityFactory;

		[Inject]
		public void Construct(GameEntity.Factory gameEntityFactory)
			=> _gameEntityFactory = gameEntityFactory;

		private void Start()
		{
			var e = _gameEntityFactory.Create();
			e.AddDebugName("PlayerChoiceWindow");
			e.isPlayerChoiceWindow = true;
			e.isToggled = false;
			e.MakeAttachable();
			e.isRequirePreparation = true;
			var entity = Contexts.sharedInstance.game.GetGroup(PlayerChoiceWindow).GetSingleEntity();
			entity.ReplaceView(_playerChoicePrefab);
			entity.ReplacePlayerWindowContent(_content);
		}
	}
}