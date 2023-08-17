using UnityEngine;
using UnityEngine.Serialization;
using static GameMatcher;

namespace EcoFarm
{
    public class PlayerChoiceRegister : MonoBehaviour
    {
        [SerializeField] private GameObject _playerChoicePrefab;
        [SerializeField] private RectTransform _playerChoiceRectTransform;

        public void Start()
        {
            var entity = Contexts.sharedInstance.game.GetGroup(PlayerChoiceWindow).GetSingleEntity();
            entity.AddView(_playerChoicePrefab);
            entity.AddPlayerWindow(_playerChoiceRectTransform);
        }
    }
}