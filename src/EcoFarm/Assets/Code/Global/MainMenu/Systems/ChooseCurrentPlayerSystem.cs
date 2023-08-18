using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ChooseCurrentPlayerSystem : ReactiveSystem<PlayerEntity>
    {
        private static PlayerView PlayerViewPrefab => ServicesMediator.DataProvider.PlayerView;

        public ChooseCurrentPlayerSystem(Contexts contexts) :
            base(contexts.player)
        { 
        }

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(AllOf(CurrentPlayer));

        protected override bool Filter(PlayerEntity entity) => entity.isCurrentPlayer;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(ChangeCurrentPlayer);

        private void ChangeCurrentPlayer(PlayerEntity player)
        {
            player.ReplaceNickname(PlayerViewPrefab.Player.Nickname);
            player.ReplaceCompletedLevelsCount(PlayerViewPrefab.Player.CompletedLevelsCount);

            Debug.Log(player.nickname.Value);
        }
    }
}