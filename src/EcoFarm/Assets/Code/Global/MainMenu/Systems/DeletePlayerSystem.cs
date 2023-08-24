using System.Collections.Generic;
using Entitas;
using Entitas.VisualDebugging.Unity;
using UnityEngine;
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

        private void Delete(PlayerEntity player)
        {
            var playerView = player.playerToEdit.Value;
            Debug.Log($"{playerView.Player.Nickname} delete him");
            Players.Remove(playerView.Player);
            PlayersList.SaveChanges();
            playerView.gameObject.DestroyGameObject();
        }
    }
}