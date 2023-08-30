using Entitas;
using Zenject;

namespace EcoFarm
{
    public class ShowGreetingSystem : IExecuteSystem
    {
        private static GameEntity Greeting => Contexts.sharedInstance.game.greetingNicknameEntity;

        public void Execute()
        {
            var player = Contexts.sharedInstance.player.currentPlayerEntity;

            if (player.hasNickname)
            {
                Greeting.ReplaceGreetingNickname("Привет, " + player.nickname.Value);
                Greeting.view.Value.SetActive(true);
            }
            else
            {
                Greeting.view.Value.SetActive(false);
            }
        }
    }
}