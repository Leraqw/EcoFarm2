using UnityEngine;
using UnityEngine.Serialization;
using static GameMatcher;

namespace EcoFarm
{
    public class PlayerChoiceRegister : MonoBehaviour
    {
        //   [field: SerializeField] public EnabledView EnabledView { get; private set; }
        [SerializeField] private GameObject _playerChoicePrefab;

        public void Start()
        {
            var entity = Contexts.sharedInstance.game.GetGroup(PlayerChoiceWindow).GetSingleEntity();
            entity.AddView(_playerChoicePrefab);
            //   EnabledView.Register(entity);
        }
    }
}