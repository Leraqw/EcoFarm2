using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public class PlayerChoiceRegister : MonoBehaviour
    {
        [SerializeField] private GameObject _playerChoicePrefab;

        public void Start()
        {
            var entity = Contexts.sharedInstance.game.GetGroup(PlayerChoiceWindow).GetSingleEntity();
            entity.AddView(_playerChoicePrefab);
        }
    }
}