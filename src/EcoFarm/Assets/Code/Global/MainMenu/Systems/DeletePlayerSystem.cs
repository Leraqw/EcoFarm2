using System.Collections.Generic;
using Entitas;
using Entitas.VisualDebugging.Unity;
using static PlayerMatcher;

namespace EcoFarm
{
    public class DeletePlayerSystem : ReactiveSystem<PlayerEntity>
    {
        public DeletePlayerSystem(Contexts contexts) : base(contexts.player)
        {
        }

        private static PlayersList PlayersList => ServicesMediator.DataProvider.PlayersList;

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(AllOf(PlayerToEdit, ToDelete));

        protected override bool Filter(PlayerEntity entity) => entity.hasPlayerToEdit && entity.isToDelete;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(Delete);

        private static void Delete(PlayerEntity entity)
        {
            var playerView = entity.playerToEdit.Value;

            PlayersList.RemovePlayer(playerView.Player);
            
            playerView.gameObject.DestroyGameObject();
            entity.isToDelete = false;
        }
    }
}