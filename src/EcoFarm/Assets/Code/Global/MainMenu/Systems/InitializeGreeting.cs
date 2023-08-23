using Entitas;
using TMPro;
using UnityEngine;

namespace EcoFarm
{
    public class InitializeGreeting : MonoBehaviour, IGreetingNicknameListener
    {
        [SerializeField] private TextMeshProUGUI _nickname;

        public InitializeGreeting(Contexts _)
        {
        }

        private void Start()
        {
            var greeting = Contexts.sharedInstance.game.CreateEntity();
            greeting.AddGreetingNickname("hello player");
            greeting.AddView(gameObject);
            greeting.AddDebugName("greeting");
            greeting.AddGreetingNicknameListener(this);
        }
 
        public void OnGreetingNickname(GameEntity entity, string value) =>
            _nickname.text = entity.greetingNickname.Value;
    }
}