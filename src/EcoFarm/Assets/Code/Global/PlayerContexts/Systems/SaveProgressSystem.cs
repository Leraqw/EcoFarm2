using System.Collections.Generic;
using Entitas;

namespace EcoFarm
{
    public sealed class SaveProgressSystem : ReactiveSystem<PlayerEntity>
    {
        private readonly Contexts _contexts;
        private readonly IDataProviderService _dataProvider;

        public SaveProgressSystem(Contexts contexts, IDataProviderService dataProvider)
            : base(contexts.player)
        {
            _contexts = contexts;
            _dataProvider = dataProvider;
        }

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(PlayerMatcher.SessionResult);

        private PlayerEntity Player => _contexts.player.currentPlayerEntity;
        private PlayersList PlayersList => _dataProvider.PlayersList;
        private List<Player> Players => _dataProvider.PlayersList.Players;

        protected override bool Filter(PlayerEntity entity) => entity.sessionResult.Value == SessionResult.Victory;

        protected override void Execute(List<PlayerEntity> entites) => entites.ForEach(Save);

        private void Save(PlayerEntity entity)
        {
            var currentLevel = Player.selectedLevel.Value + 1;
            if (currentLevel > Player.completedLevelsCount.Value)
            {
                Player.ReplaceCompletedLevelsCount(currentLevel);
                UpdatePlayerCompletedLevelsCount(Player.nickname.Value, currentLevel);
            }
        }

        private void UpdatePlayerCompletedLevelsCount(string nickname, int completedLevelsCount)
        {
            var index = Players.FindIndex(p => p.Nickname.Equals(nickname));

            Players[index].CompletedLevelsCount = completedLevelsCount;

            PlayersList.SaveChanges();
        }
    }
}