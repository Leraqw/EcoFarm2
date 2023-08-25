using System.Collections.Generic;
using Entitas;
using static EcoFarm.PlayerExtensions;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ChangePlayerDataSystem : ReactiveSystem<PlayerEntity>
    {
        public ChangePlayerDataSystem(Contexts contexts) : base(contexts.player)
        {
        }

        private static PlayersList PlayersList => ServicesMediator.DataProvider.PlayersList;
        private static List<Player> Players => ServicesMediator.DataProvider.PlayersList.Players;

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(AllOf(PlayerToEdit, EditedPlayerData));

        protected override bool Filter(PlayerEntity entity) => entity.hasPlayerToEdit && entity.hasEditedPlayerData;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(Edit);

        private static void Edit(PlayerEntity entity)
        {
            var player = entity.playerToEdit.Value.Player;

            var index = FindPlayerIndex(player);
            if (index != -1) Players[index] = entity.editedPlayerData.Value;

            PlayersList.SaveChanges();

            entity.RemoveEditedPlayerData();
        }
    }
}