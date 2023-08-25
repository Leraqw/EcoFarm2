using System.Collections.Generic;
using System.Linq;
using Entitas;
using static PlayerMatcher;

namespace EcoFarm
{
    public class PlayerListChangedSystem : ReactiveSystem<PlayerEntity>, IPlayerListLengthChangedListener
    {
        private readonly PlayerContext _context;
        private PlayerEntity CurrentPlayer => _context.GetEntities(PlayerMatcher.Player).First();

        public PlayerListChangedSystem(Contexts contexts) : base(contexts.player) => _context = contexts.player;

        private static GameEntity GreetingEntity =>
            Contexts.sharedInstance.game.GetEntities(GameMatcher.GreetingNickname).First();

        private static List<Player> Players => ServicesMediator.DataProvider.PlayersList.Players;


        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(ForPlayerButton);

        protected override bool Filter(PlayerEntity entity) => entity.isForPlayerButton;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(ChangePlayerListLength);

        private void ChangePlayerListLength(PlayerEntity e)
        {
            e.ReplacePlayerListLengthChanged(Players.Count);
            e.AddPlayerListLengthChangedListener(this);
        }

        public void OnPlayerListLengthChanged(PlayerEntity entity, int value)
        {
            var hasPlayers = value > 0;
            entity.ReplaceInteractable(hasPlayers);
            GreetingEntity.view.Value.SetActive(hasPlayers);
            
            if (hasPlayers)
            {
                CurrentPlayer.isCurrentPlayer = true;
                CurrentPlayer.ReplaceNickname(Players.First().Nickname);
                CurrentPlayer.ReplaceCompletedLevelsCount(Players.First().CompletedLevelsCount);
            }
        }
    }
}