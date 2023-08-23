using System.Collections.Generic;
using System.Linq;
using Entitas;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ShowGreetingSystem : ReactiveSystem<PlayerEntity>
    {
        public ShowGreetingSystem(Contexts contexts) : base(contexts.player)
        {
        }

        private static GameEntity Greeting =>
            Contexts.sharedInstance.game.GetEntities(GameMatcher.GreetingNickname).First();

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(AllOf(CurrentPlayer, Nickname));

        protected override bool Filter(PlayerEntity entity) => entity.isCurrentPlayer;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(ReplaceGreetingNickname);

        private void ReplaceGreetingNickname(PlayerEntity player)
        {
            Greeting.ReplaceGreetingNickname("Привет, " + player.nickname.Value);
            
            Greeting.view.Value.GetComponent<IGreetingNicknameListener>()
                .OnGreetingNickname(Greeting, Greeting.greetingNickname.Value);
        }
    }
}