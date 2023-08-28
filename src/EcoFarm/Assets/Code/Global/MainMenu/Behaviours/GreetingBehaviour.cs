using TMPro;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
    public class GreetingBehaviour : MonoBehaviour, IGreetingNicknameListener
    {
        [SerializeField] private TextMeshProUGUI _nickname;
        private GameEntity.Factory _gameEntityFactory;

        [Inject]
        public void Construct(GameEntity.Factory gameEntityFactory) => _gameEntityFactory = gameEntityFactory;
        
        private void Start()
        {
            var greeting = _gameEntityFactory.Create();
            greeting.AddGreetingNickname("");
            greeting.AddDebugName("greeting");
            greeting.AddView(gameObject);
            greeting.AddGreetingNicknameListener(this);

            greeting.view.Value.SetActive(false);
        }

        public void OnGreetingNickname(GameEntity entity, string value) => _nickname.text = value;
    }
}