using TMPro;
using UnityEngine;

namespace EcoFarm
{
    public class GreetingBehaviour : MonoBehaviour, IGreetingNicknameListener
    {
        [SerializeField] private TextMeshProUGUI _nickname;

        private void Start()
        {
            var greeting = Contexts.sharedInstance.game.CreateEntity();
            greeting.AddGreetingNickname("");
            greeting.AddDebugName("greeting");
            greeting.AddView(gameObject);
            greeting.AddGreetingNicknameListener(this);

            greeting.view.Value.SetActive(false);
        }

        public void OnGreetingNickname(GameEntity entity, string value) =>
            _nickname.text = entity.greetingNickname.Value;
    }
}