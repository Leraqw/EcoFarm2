using System.Collections.Generic;
using Entitas;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ChangePlayerDataSystem : ReactiveSystem<PlayerEntity>
    {
        private readonly Contexts _contexts;
        private readonly IDataProviderService _dataProvider;

        public ChangePlayerDataSystem(Contexts contexts, IDataProviderService dataProvider)
            : base(contexts.player)
        {
            _contexts = contexts;
            _dataProvider = dataProvider;
        }

        private PlayersList PlayersList => _dataProvider.PlayersList;
        private List<Player> Players => _dataProvider.PlayersList.Players;

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(AllOf(PlayerToEdit, EditedPlayerData));

        protected override bool Filter(PlayerEntity entity) => entity.hasPlayerToEdit && entity.hasEditedPlayerData;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(Edit);

        private void Edit(PlayerEntity entity)
        {
            var player = entity.playerToEdit.Value.Player;
            var newNickname = entity.editedPlayerData.Value.Nickname;

            PlayersList.ChangePlayer(player, newNickname);

            entity.RemoveEditedPlayerData();
        }
    }
}