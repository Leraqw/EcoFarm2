using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public class EditPlayerDataSystem : ReactiveSystem<PlayerEntity>
    {
        public EditPlayerDataSystem(Contexts contexts) : base(contexts.player)
        {
        }

        private static PlayersList PlayersList => ServicesMediator.DataProvider.PlayersList;
        private static List<Player> Players => ServicesMediator.DataProvider.PlayersList.Players;

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(AllOf(PlayerToEdit, EditedPlayerData));

        protected override bool Filter(PlayerEntity entity) => entity.hasPlayerToEdit && entity.hasEditedPlayerData;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(Edit);

        private void Edit(PlayerEntity player)
        {
            var playerView = player.playerToEdit.Value;
            Debug.Log($"{playerView.Player} edit him");
            
            var p = Players.Find(p => p.Equals(playerView.Player));
            Debug.Log($"{p.Nickname}");
            if (p != null) p = player.editedPlayerData.Value;
 
            PlayersList.SaveChanges();
        }
    }
}