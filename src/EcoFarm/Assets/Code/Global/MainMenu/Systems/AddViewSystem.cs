using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public class AddViewSystem : ReactiveSystem<GameEntity>
    {
        // readonly Transform _viewContainer = new GameObject("Game Views").transform;
        readonly GameContext _context;

        public AddViewSystem(Contexts contexts) : base(contexts.game) => _context = contexts.game;

        private static IEnumerable<Player> Players => ServicesMediator.DataProvider.Players;

        private static PlayerView PlayerViewPrefab => ServicesMediator.DataProvider.PlayerView;


        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(AllOf(PlayerChoiceWindow, Toggled, RequirePreparation));

        protected override bool Filter(GameEntity entity) => entity.isToggled && entity.isRequirePreparation;

        protected override void Execute(List<GameEntity> entities) => entities.ForEach(AddPlayers);

        private void AddPlayers(GameEntity window)
        {
            Players.ForEach((player) => BindPlayerChoiceView(player, PlayerViewPrefab, window));
            window.isPrepared = true;
        }

        private void BindPlayerChoiceView(Player player, PlayerView playerViewPrefab, GameEntity window)
        {
            var e = _context.CreateEntity();
            e.AddDebugName("playerItem");
            e.AddUiParent(window.playerWindow.Value);
            e.AddViewPrefab(playerViewPrefab.gameObject);
            e.AddPlayerToChoose(player);
            playerViewPrefab.Register(e);

            Object.Instantiate(e.viewPrefab.Value, e.uiParent.Value);
        }
    }
}