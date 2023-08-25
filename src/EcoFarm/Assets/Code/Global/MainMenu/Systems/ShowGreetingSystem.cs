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

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(Nickname);

        protected override bool Filter(PlayerEntity entity) => entity.hasNickname;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(ReplaceGreetingNickname);

        private static void ReplaceGreetingNickname(PlayerEntity player)
        {
            var greeting = Contexts.sharedInstance.game.GetEntities(GameMatcher.GreetingNickname).First();

            greeting.ReplaceGreetingNickname("Привет, " + player.nickname.Value);

            greeting.view.Value.SetActive(true);
        }
    }
}