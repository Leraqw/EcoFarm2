using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public class ButtonPlayerChoiceBehaviour : MonoBehaviour
    {
        [SerializeField] private GameObject _playerChoicePrefab;
        [SerializeField] private RectTransform _content;

        private void Start()
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