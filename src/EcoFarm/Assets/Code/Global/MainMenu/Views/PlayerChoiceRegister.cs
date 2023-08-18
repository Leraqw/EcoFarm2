using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public class PlayerChoiceRegister : StartEntityBehaviour
    {
        [SerializeField] private GameObject _playerChoicePrefab;
        [SerializeField] private RectTransform _content;

        protected override void Initialize()
        {
            var e = Contexts.sharedInstance.game.CreateEntity();
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