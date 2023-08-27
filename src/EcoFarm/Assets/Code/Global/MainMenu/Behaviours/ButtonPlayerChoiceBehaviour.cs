using UnityEngine;
using Zenject;
using static GameMatcher;

namespace EcoFarm
{
	public class ButtonPlayerChoiceBehaviour : MonoBehaviour
	{
		[SerializeField] private GameObject _playerChoicePrefab;
		[SerializeField] private RectTransform _content;

		private GameEntity.Factory _gameEntityFactory;
		private PlayerEntity.Factory _playerEntityFactory;
		private GameContext _context;

		[Inject]
		public void Construct
		(
			GameEntity.Factory gameEntityFactory,
			PlayerEntity.Factory playerEntityFactory, 
		    GameContext context
		)
		{
            _gameEntityFactory = gameEntityFactory;
            _playerEntityFactory = playerEntityFactory;
            _context = context;
		}

		private void Start()
		{
			var e = _gameEntityFactory.Create();
			e.AddDebugName("PlayerChoiceWindow");
			e.isPlayerChoiceWindow = true;
			e.isWindow = true;
            e.isToggled = false;
            e.MakeAttachable();
            e.isRequirePreparation = true;
            
            CreatePlayerItemEntity();
            CreateModeEntity();
        }

		private void CreatePlayerItemEntity()
		{
			var entity = _context.GetGroup(PlayerChoiceWindow).GetSingleEntity();
			entity.ReplaceView(_playerChoicePrefab);
			entity.ReplacePlayerWindowContent(_content);
		}

		private void CreateModeEntity()
        {
            var mode = _playerEntityFactory.Create();
            mode.ReplaceEditMode(false);
        }
	}
}