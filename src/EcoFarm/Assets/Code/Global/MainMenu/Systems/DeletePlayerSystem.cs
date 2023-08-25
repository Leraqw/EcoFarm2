using System.Collections.Generic;
using Entitas;
using Entitas.VisualDebugging.Unity;
using UnityEngine;
using static EcoFarm.PlayerExtensions;
using static PlayerMatcher;

namespace EcoFarm
{
    public class DeletePlayerSystem : ReactiveSystem<PlayerEntity>
    {
        public DeletePlayerSystem(Contexts contexts) : base(contexts.player)
        {
        }

        private static PlayersList PlayersList => ServicesMediator.DataProvider.PlayersList;
        private static List<Player> Players => ServicesMediator.DataProvider.PlayersList.Players;

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(AllOf(PlayerToEdit, ToDelete));

        protected override bool Filter(PlayerEntity entity) => entity.hasPlayerToEdit && entity.isToDelete;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(Delete);

        private static void Delete(PlayerEntity entity)
        {
            var playerView = entity.playerToEdit.Value;

            var index = FindPlayerIndex(playerView.Player);
            if (index != -1) Players.Remove(Players[index]);
            PlayersList.SaveChanges();
            playerView.gameObject.DestroyGameObject();

          entity.isToDelete = false;
        }
    }
}