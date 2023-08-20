using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public class ButtonCreateNewPlayerBehaviour : MonoBehaviour
    {
        [SerializeField] private GameObject _playerChoicePrefab;

        private void Start()
        {
            var e = Contexts.sharedInstance.game.CreateEntity();
            e.AddDebugName("CreateNewPlayerWindow");
            e.isWindow = true;
            e.isCreateNewPlayerWindow = true;
            e.isToggled = false;
            e.MakeAttachable();
            e.isPrepared = true;
            var entity = Contexts.sharedInstance.game.GetGroup(CreateNewPlayerWindow).GetSingleEntity();
            entity.ReplaceView(_playerChoicePrefab);
        }
    }
}