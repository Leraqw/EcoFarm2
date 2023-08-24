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
            => context.CreateCollector(AllOf(PlayerToEdit, ToEditPlayerData));

        protected override bool Filter(PlayerEntity entity) => entity.hasPlayerToEdit;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(Edit);

        private void Edit(PlayerEntity player)
        {
            var playerView = player.playerToEdit.Value;
            Debug.Log($"{playerView.Player} edit him");
            
            var p = Players.Find(p => p == playerView.Player); 
            if (p != null) p.Nickname = "haha"; 
            PlayersList.SaveChanges();
        }
    }
}